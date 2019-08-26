IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FENTS_ByEntity]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[FENTS_ByEntity]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[FENTS_ByEntity]
(	 
	 @pintBUSI_Code				INT 
	,@pintENTI_Code				INT 
) 
AS
BEGIN
	
	SELECT
	ETYP.BUSI_Code AS BUSI_Code ,
    ETYP.ETYP_Code AS ETYP_Code ,
    ETYP.ETYP_Name AS FENT_Name ,
    ETYP.ETYP_Description AS FENT_Description ,
	CONVERT(BIT,0) AS FENT_Select 
    INTO #TMP_EntityTypes
	FROM dbo.VENPY_EntityTypes AS ETYP
	WHERE 
	ETYP.BUSI_Code = @pintBUSI_Code AND 
	ETYP.ETYP_Active = 1

	UPDATE ETYP
		SET ETYP.FENT_Select = CONVERT(BIT,1)
	FROM #TMP_EntityTypes AS ETYP
	INNER JOIN dbo.VENPY_FunctionsEntities AS FENT ON	FENT.BUSI_Code = ETYP.BUSI_Code AND 
														FENT.ETYP_Code = ETYP.ETYP_Code AND 
														FENT.ENTI_Code = @pintENTI_Code

	SELECT * FROM #TMP_EntityTypes

END
GO 

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FENTI_ByEntity]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[FENTI_ByEntity]
GO

IF EXISTS (SELECT * FROM sys.types WHERE user_type_id =  TYPE_ID('[dbo].[UDTT_FunctionsEntities]'))
	DROP TYPE [dbo].[UDTT_FunctionsEntities]
GO 

CREATE TYPE [dbo].[UDTT_FunctionsEntities] AS TABLE(
	BUSI_Code INT NOT NULL,
	ENTI_Code INT NOT NULL,
	ETYP_Code INT NOT NULL
)
GO 

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[FENTI_ByEntity]
(	 
	 @pintBUSI_Code					INT 
	,@pintENTI_Code					INT
	,@ptabUDTT_FunctionsEntities	UDTT_FunctionsEntities READONLY
	,@pvchAUDI_CreationUser			VARCHAR(20)  
) 
AS
BEGIN

	DELETE FROM dbo.VENPY_FunctionsEntities WHERE BUSI_Code = @pintBUSI_Code AND ENTI_Code = @pintENTI_Code
	SELECT * INTO #TMP_FunctionsEntities FROM @ptabUDTT_FunctionsEntities

	INSERT INTO dbo.VENPY_FunctionsEntities
			( BUSI_Code		, ENTI_Code		, ETYP_Code		, AUDI_CreationUser		, AUDI_CreationDate )
	SELECT
		 TFEN.BUSI_Code
		,@pintENTI_Code
		,TFEN.ETYP_Code
		,@pvchAUDI_CreationUser
		,GETDATE()
	FROM #TMP_FunctionsEntities AS TFEN


END 
GO 