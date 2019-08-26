IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ETYPS_ListEntityTypes]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[ETYPS_ListEntityTypes]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[ETYPS_ListEntityTypes]
(	 
	 @pintBUSI_Code		INT 
	,@pvchETYP_Name		VARCHAR(100)
) 
AS
BEGIN

	SELECT	 ETYP.BUSI_Code			,ETYP.ETYP_Code		,ETYP.ETYP_Name 
			,ETYP.ETYP_Description	,ETYP.ETYP_Active	,ETYP.ETYP_Default 
	FROM dbo.VENPY_EntityTypes AS ETYP
	WHERE 
	ETYP.BUSI_Code = @pintBUSI_Code AND
	ETYP.ETYP_Name LIKE '%' + ISNULL(@pvchETYP_Name,'') + '%' 

END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ETYPS_AEntityType]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[ETYPS_AEntityType]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[ETYPS_AEntityType]
(	 
	 @pintBUSI_Code		INT 
	,@pintETYP_Code		INT 
) 
AS
BEGIN

	SELECT	 ETYP.BUSI_Code			,ETYP.ETYP_Code		,ETYP.ETYP_Name 
			,ETYP.ETYP_Description	,ETYP.ETYP_Active	,ETYP.ETYP_Default 
	FROM dbo.VENPY_EntityTypes AS ETYP
	WHERE 
	ETYP.BUSI_Code = @pintBUSI_Code AND
	ETYP.ETYP_Code = @pintETYP_Code

END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ETYPI_AEntityType]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[ETYPI_AEntityType]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[ETYPI_AEntityType]
( 
	 @pintBUSI_Code				INT  
	,@pintETYP_Code				INT  
	,@pvchETYP_Name				VARCHAR(100) 
	,@pvchETYP_Description		VARCHAR(150) 
	,@pbitETYP_Active			BIT 
	,@pbitETYP_Default			BIT 
	,@pvchAUDI_CreationUser		VARCHAR(20) 
	,@pvchETYP_ErrorMessage		VARCHAR(MAX) OUTPUT
) 
AS 
BEGIN
	IF NOT EXISTS (SELECT ETYP_Code FROM [VENPY_EntityTypes] 
					WHERE BUSI_Code = @pintBUSI_Code AND RTRIM(LTRIM(ETYP_Name)) = RTRIM(LTRIM(@pvchETYP_Name)) )
	BEGIN
		SET @pintETYP_Code = ISNULL((SELECT MAX(ETYP_Code) FROM [VENPY_EntityTypes] WHERE BUSI_Code = @pintBUSI_Code) + 1,1)
			INSERT INTO [VENPY_EntityTypes]
			     ( BUSI_Code	, ETYP_Code		, ETYP_Name			, ETYP_Description
			     , ETYP_Active	, ETYP_Default	, AUDI_CreationUser	, AUDI_CreationDate)   
			VALUES
			     ( @pintBUSI_Code	, @pintETYP_Code	, @pvchETYP_Name			, @pvchETYP_Description
			     , @pbitETYP_Active , @pbitETYP_Default , @pvchAUDI_CreationUser	, GETDATE())
	END
	ELSE
	BEGIN 
		SET @pvchETYP_ErrorMessage = 'Ya existe un Tipo de Entidad con el nombre ' + @pvchETYP_Name
	END
END
GO


IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ETYPU_AEntityType]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[ETYPU_AEntityType]

GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[ETYPU_AEntityType]
( 
	 @pintBUSI_Code				INT  
	,@pintETYP_Code				INT  
	,@pvchETYP_Name				VARCHAR(100) 
	,@pvchETYP_Description		VARCHAR(150) 
	,@pbitETYP_Active			BIT 
	,@pbitETYP_Default			BIT 
	,@pvchAUDI_ModificationUser	VARCHAR(20) 
	,@pvchETYP_ErrorMessage		VARCHAR(MAX) OUTPUT
) 
AS 
BEGIN

	IF NOT EXISTS (SELECT ETYP_Code FROM [VENPY_EntityTypes] 
					WHERE BUSI_Code = @pintBUSI_Code AND RTRIM(LTRIM(ETYP_Name)) = RTRIM(LTRIM(@pvchETYP_Name)) AND ETYP_Code <> @pintETYP_Code )
	BEGIN
		UPDATE [VENPY_EntityTypes]
		   SET [ETYP_Name] = @pvchETYP_Name
		     , [ETYP_Description] = @pvchETYP_Description
		     , [ETYP_Active] = @pbitETYP_Active
		     , [ETYP_Default] = @pbitETYP_Default
		     , [AUDI_ModificationUser] = @pvchAUDI_ModificationUser
		     , [AUDI_ModificationDate] = GETDATE()
		WHERE 
			[BUSI_Code] = @pintBUSI_Code AND 
			[ETYP_Code] = @pintETYP_Code
	END
	ELSE
	BEGIN 
		SET @pvchETYP_ErrorMessage  = 'Ya existe un Tipo de Entidad con el nombre ' + @pvchETYP_Name
	END

END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ETYPD_AEntityType]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[ETYPD_AEntityType]

GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[ETYPD_AEntityType]
( 
	 @pintBUSI_Code				INT  
	,@pintETYP_Code				INT  
) 
AS 
BEGIN
	
	DELETE FROM [VENPY_EntityTypes]
    WHERE 
		[BUSI_Code] = @pintBUSI_Code AND 
		[ETYP_Code] = @pintETYP_Code

END
GO 