IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BOFFS_ByUser]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[BOFFS_ByUser]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[BOFFS_ByUser]
(	 
	 @pintUSER_Code		INT 
	,@pintBUSI_Code		INT
) 
AS
BEGIN
	
	SELECT	BOFF.BUSI_Code		, BOFF.BOFF_Code		, BOFF.BOFF_Name
		  , BOFF.BOFF_Address	, BOFF.BOFF_Description	, BUSI.BUSI_RUC
	FROM dbo.VENPY_BranchOffices AS BOFF
	INNER JOIN dbo.VENPY_Business AS BUSI ON BUSI.BUSI_Code = BOFF.BUSI_Code
	INNER JOIN dbo.VENPY_BranchOfficesUsers AS UBOFF ON UBOFF.BUSI_Code = BOFF.BUSI_Code AND UBOFF.BOFF_Code = BOFF.BOFF_Code
	WHERE 
	UBOFF.USER_Code = @pintUSER_Code AND	
	BUSI.BUSI_Code = ISNULL(@pintBUSI_Code, BUSI.BUSI_Code)

END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BOFFS_ListBranchOffices]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[BOFFS_ListBranchOffices]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[BOFFS_ListBranchOffices]
(	 
	 @pintBUSI_Code		INT 
	,@pintUSER_Code		INT 
	,@pvchBOFF_Name		VARCHAR(100) 
) 
AS
BEGIN

	SELECT   BOFF.BUSI_Code			,BOFF.BOFF_Code			,BOFF.BOFF_Name	,BOFF.BOFF_Address
			,BOFF.BOFF_Description	,BOFF.BOFF_Email		,BOFF.BOFF_Web	,BOFF.BOFF_SocialNetworks
			,BOFF.BOFF_PhoneNumber1	,BOFF.BOFF_PhoneNumber2	,BOFF.UBIG_Code 
			,UDEP.UBIG_Description AS BOFF_Departamento
			,UPRO.UBIG_Description AS BOFF_Provincia
			,UDIS.UBIG_Description AS BOFF_Distrito
	FROM VENPY_BranchOffices AS BOFF
	INNER JOIN dbo.VENPY_BranchOfficesUsers AS UBOFF ON UBOFF.BUSI_Code = BOFF.BUSI_Code AND UBOFF.BOFF_Code = BOFF.BOFF_Code
	INNER JOIN dbo.VENPY_Ubigeos AS UDEP ON UDEP.UBIG_Code = SUBSTRING(BOFF.UBIG_Code,1,2)
	INNER JOIN dbo.VENPY_Ubigeos AS UPRO ON UPRO.UBIG_Code = SUBSTRING(BOFF.UBIG_Code,1,5)
	INNER JOIN dbo.VENPY_Ubigeos AS UDIS ON UDIS.UBIG_Code = BOFF.UBIG_Code
	WHERE 
	BOFF.BUSI_Code = @pintBUSI_Code AND 
	UBOFF.USER_Code = @pintUSER_Code AND
	BOFF.BOFF_Name LIKE '%' + ISNULL(@pvchBOFF_Name,'') + '%' 

END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BOFFS_ABranchOffice]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[BOFFS_ABranchOffice]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[BOFFS_ABranchOffice]
(	 
	 @pintBUSI_Code	INT 
	,@pintBOFF_Code	INT 
) 
AS
BEGIN

	SELECT   BOFF.BUSI_Code			,BOFF.BOFF_Code			,BOFF.BOFF_Name	,BOFF.BOFF_Address
			,BOFF.BOFF_Description	,BOFF.BOFF_Email		,BOFF.BOFF_Web	,BOFF.BOFF_SocialNetworks
			,BOFF.BOFF_PhoneNumber1	,BOFF.BOFF_PhoneNumber2	,BOFF.UBIG_Code 
			,SUBSTRING(BOFF.UBIG_Code,1,2) AS BOFF_CodeDepartamento
			,SUBSTRING(BOFF.UBIG_Code,1,5) AS BOFF_CodeProvincia
			,BOFF.UBIG_Code AS BOFF_CodeDistrito
	FROM VENPY_BranchOffices AS BOFF
	WHERE 
	BOFF.BUSI_Code = @pintBUSI_Code AND 
	BOFF.BOFF_Code = @pintBOFF_Code

END
GO


IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BOFFI_ABranchOffice]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[BOFFI_ABranchOffice]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[BOFFI_ABranchOffice]
( 
	 @pintBUSI_Code				INT 
	,@pintBOFF_Code				INT OUTPUT
	,@pvchBOFF_Name				VARCHAR(100) 
	,@pvchBOFF_Address			VARCHAR(100) 
	,@pvchBOFF_Description		VARCHAR(250) 
	,@pvchBOFF_Email			VARCHAR(150) 
	,@pvchBOFF_Web				VARCHAR(100) 
	,@pvchBOFF_SocialNetworks	VARCHAR(250) 
	,@pvchBOFF_PhoneNumber1		VARCHAR(25) 
	,@pvchBOFF_PhoneNumber2		VARCHAR(25) 
	,@pvchUBIG_Code				VARCHAR(20) 
	,@pvchAUDI_CreationUser		VARCHAR(20) 
	,@pvchBOFF_ErrorMessage		VARCHAR(MAX) OUTPUT
) 
AS 
BEGIN

	IF NOT EXISTS (SELECT BOFF_Code FROM [VENPY_BranchOffices] WHERE BUSI_Code = @pintBUSI_Code AND RTRIM(LTRIM(BOFF_Name)) = RTRIM(LTRIM(@pvchBOFF_Name)) )
	BEGIN
		SET @pintBOFF_Code = ISNULL((SELECT MAX(BOFF_Code) FROM [VENPY_BranchOffices] WHERE BUSI_Code = @pintBUSI_Code) + 1 ,1)
		INSERT INTO [VENPY_BranchOffices]
			(BUSI_Code			, BOFF_Code			, BOFF_Name		, BOFF_Address
			,BOFF_Description	, BOFF_Email		, BOFF_Web		, BOFF_SocialNetworks
			,BOFF_PhoneNumber1	, BOFF_PhoneNumber2	, UBIG_Code		, AUDI_CreationUser
			,AUDI_CreationDate  )
		VALUES
			(@pintBUSI_Code			, @pintBOFF_Code			, @pvchBOFF_Name	, @pvchBOFF_Address
			,@pvchBOFF_Description	, @pvchBOFF_Email			, @pvchBOFF_Web		, @pvchBOFF_SocialNetworks
			,@pvchBOFF_PhoneNumber1	, @pvchBOFF_PhoneNumber2	, @pvchUBIG_Code	, @pvchAUDI_CreationUser
			,GETDATE() )
	END
	ELSE
	BEGIN 
		SET @pvchBOFF_ErrorMessage = 'Ya existe una Sucursal que pertenece a la misma Empresa con el nombre ' + @pvchBOFF_Name
	END

END
GO


IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BOFFU_ABranchOffice]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[BOFFU_ABranchOffice]

GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[BOFFU_ABranchOffice]
( 
	 @pintBUSI_Code				INT 
	,@pintBOFF_Code				INT 
	,@pvchBOFF_Name				VARCHAR(100) 
	,@pvchBOFF_Address			VARCHAR(100) 
	,@pvchBOFF_Description		VARCHAR(250) 
	,@pvchBOFF_Email			VARCHAR(150) 
	,@pvchBOFF_Web				VARCHAR(100) 
	,@pvchBOFF_SocialNetworks	VARCHAR(250) 
	,@pvchBOFF_PhoneNumber1		VARCHAR(25) 
	,@pvchBOFF_PhoneNumber2		VARCHAR(25) 
	,@pvchUBIG_Code				VARCHAR(20) 
	,@pvchAUDI_ModificationUser	VARCHAR(20) 
	,@pvchBOFF_ErrorMessage		VARCHAR(MAX) OUTPUT
) 
AS 
BEGIN

	IF NOT EXISTS (SELECT BOFF_Code FROM [VENPY_BranchOffices] WHERE BUSI_Code = @pintBUSI_Code AND RTRIM(LTRIM(BOFF_Name)) = RTRIM(LTRIM(@pvchBOFF_Name)) AND BOFF_Code <> @pintBOFF_Code )
	BEGIN
		UPDATE [VENPY_BranchOffices]
		   SET 
			 [BOFF_Name]				= @pvchBOFF_Name
			,[BOFF_Address]				= @pvchBOFF_Address
			,[BOFF_Description]			= @pvchBOFF_Description
			,[BOFF_Email]				= @pvchBOFF_Email
			,[BOFF_Web]					= @pvchBOFF_Web
			,[BOFF_SocialNetworks]		= @pvchBOFF_SocialNetworks
			,[BOFF_PhoneNumber1]		= @pvchBOFF_PhoneNumber1
			,[BOFF_PhoneNumber2]		= @pvchBOFF_PhoneNumber2
			,[UBIG_Code]				= @pvchUBIG_Code
			,[AUDI_ModificationUser]	= @pvchAUDI_ModificationUser
			,[AUDI_ModificationDate]	= GETDATE()
		WHERE 
			[BUSI_Code] = @pintBUSI_Code AND 
			[BOFF_Code] = @pintBOFF_Code
	END
	ELSE
	BEGIN 
		SET @pvchBOFF_ErrorMessage = 'Ya existe una Sucursal que pertenece a la misma Empresa con el nombre ' + @pvchBOFF_Name
	END

END
GO