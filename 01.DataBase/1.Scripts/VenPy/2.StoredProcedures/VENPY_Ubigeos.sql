IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UBIGS_All]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[UBIGS_All]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[UBIGS_All]
AS
BEGIN 
	SELECT  
		UBIG_Code				, UBIG_ParentCode	, UBIG_SunatCode ,
		UBIG_InternationalCode	, UBIG_Description	, UBIG_Observations 
	FROM dbo.VENPY_Ubigeos 
	ORDER BY UBIG_Code 
END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UBIGS_AUbigeo]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[UBIGS_AUbigeo]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[UBIGS_AUbigeo]
( 
	 @pvchUBIG_Code	VARCHAR(20) 
)
AS
BEGIN 
	SELECT  
		 UBIG_Code				, UBIG_ParentCode	, UBIG_SunatCode 
		,UBIG_InternationalCode	, UBIG_Description	, UBIG_Observations 
	FROM dbo.VENPY_Ubigeos 
	WHERE UBIG_Code = @pvchUBIG_Code
END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UBIGD_AUbigeo]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[UBIGD_AUbigeo]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[UBIGD_AUbigeo]
( 
	 @pvchUBIG_Code	VARCHAR(20) 
)
AS
BEGIN 

	DELETE FROM dbo.VENPY_Ubigeos 
	WHERE UBIG_Code = @pvchUBIG_Code

END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UBIGI_AUbigeo]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[UBIGI_AUbigeo]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[UBIGI_AUbigeo]
( 
	 @pvchUBIG_Code					VARCHAR(20) 
	,@pvchUBIG_ParentCode			VARCHAR(20) 
	,@pvchUBIG_SunatCode			VARCHAR(20) 
	,@pvchUBIG_InternationalCode	VARCHAR(20) 
	,@pvchUBIG_Description			VARCHAR(100)
	,@pvchUBIG_Observations			VARCHAR(250)
	,@pvchAUDI_CreationUser			VARCHAR(20) 
	,@pdtmAUDI_CreationDate			DATETIME 
	,@pvchUBIG_ErrorMessage			VARCHAR(MAX) OUTPUT
) 
AS 
BEGIN

	IF NOT EXISTS (SELECT UBIG_Code FROM [VENPY_Ubigeos] 
					WHERE ISNULL(RTRIM(LTRIM(UBIG_ParentCode)),'') = ISNULL(RTRIM(LTRIM(@pvchUBIG_ParentCode)),'' )
						AND RTRIM(LTRIM(UBIG_Description)) = RTRIM(LTRIM(@pvchUBIG_Description)) )
	BEGIN
		INSERT INTO [VENPY_Ubigeos]
		    ( UBIG_Code				, UBIG_ParentCode		, UBIG_SunatCode	, UBIG_InternationalCode
		    , UBIG_Description		, UBIG_Observations		, AUDI_CreationUser , AUDI_CreationDate )  
		VALUES
			( @pvchUBIG_Code		, @pvchUBIG_ParentCode		, @pvchUBIG_SunatCode		, @pvchUBIG_InternationalCode
		    , @pvchUBIG_Description , @pvchUBIG_Observations	, @pvchAUDI_CreationUser	, @pdtmAUDI_CreationDate )
	END
	ELSE
	BEGIN 
		SET @pvchUBIG_ErrorMessage = 'Ya existe un Ubigeo con la misma Descripción'
	END

END
GO


IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UBIGU_AUbigeo]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[UBIGU_AUbigeo]

GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[UBIGU_AUbigeo]
( 
	 @pvchUBIG_Code					VARCHAR(20) 
	,@pvchUBIG_ParentCode			VARCHAR(20)
	,@pvchUBIG_SunatCode			VARCHAR(20)
	,@pvchUBIG_InternationalCode	VARCHAR(20)
	,@pvchUBIG_Description			VARCHAR(100)
	,@pvchUBIG_Observations			VARCHAR(250)
	,@pvchAUDI_ModificationUser		VARCHAR(20) 
	,@pdtmAUDI_ModificationDate		DATETIME 
	,@pvchUBIG_ErrorMessage			VARCHAR(MAX) OUTPUT
)
AS 
BEGIN

	IF NOT EXISTS (SELECT UBIG_Code FROM [VENPY_Ubigeos] 
					WHERE ISNULL(RTRIM(LTRIM(UBIG_ParentCode)),'') = ISNULL(RTRIM(LTRIM(@pvchUBIG_ParentCode)),'' )
						AND RTRIM(LTRIM(UBIG_Description)) = RTRIM(LTRIM(@pvchUBIG_Description))
						AND RTRIM(LTRIM(UBIG_Code)) <> RTRIM(LTRIM(@pvchUBIG_Code)) )
	BEGIN
		UPDATE [VENPY_Ubigeos]
		  SET [UBIG_ParentCode]			= @pvchUBIG_ParentCode
			, [UBIG_SunatCode]			= @pvchUBIG_SunatCode
		    , [UBIG_InternationalCode]	= @pvchUBIG_InternationalCode
		    , [UBIG_Description]		= @pvchUBIG_Description
		    , [UBIG_Observations]		= @pvchUBIG_Observations
		    , [AUDI_ModificationUser]	= @pvchAUDI_ModificationUser
		    , [AUDI_ModificationDate]	= @pdtmAUDI_ModificationDate
		WHERE [UBIG_Code] = @pvchUBIG_Code
	END
	ELSE
	BEGIN 
		SET @pvchUBIG_ErrorMessage = 'Ya existe un Ubigeo con la misma Descripción'
	END

END
GO
