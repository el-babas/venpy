IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BUSIS_ByUser]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[BUSIS_ByUser]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[BUSIS_ByUser]
(	 @pintUSER_Code		INT ) 
AS
BEGIN
	
	SELECT DISTINCT USER_Code, BUSI_Code
	INTO #TMP_BranchOfficesUsers
	FROM dbo.VENPY_BranchOfficesUsers

	SELECT  BUSI.BUSI_Code		, BUSI.BUSI_RUC	, BUSI.BUSI_BusinessName
		   ,BUSI.BUSI_TradeName	, BUSI.BUSI_Address1
	FROM dbo.VENPY_Business AS BUSI
	INNER JOIN #TMP_BranchOfficesUsers AS TBUSI ON TBUSI.BUSI_Code = BUSI.BUSI_Code
	WHERE 
	TBUSI.USER_Code = @pintUSER_Code

END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BUSIS_ListCompanies]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[BUSIS_ListCompanies]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[BUSIS_ListCompanies]
(	 
	 @pintUSER_Code			INT 
	,@pvchBUSI_RUC			VARCHAR(11)
	,@pvchBUSI_BusinessName	VARCHAR(100)
) 
AS
BEGIN
	
	SELECT DISTINCT USER_Code, BUSI_Code
	INTO #TMP_BranchOfficesUsers
	FROM dbo.VENPY_BranchOfficesUsers

	SELECT   BUSI.BUSI_Code			,BUSI.BUSI_RUC			,BUSI.BUSI_BusinessName
			,BUSI.BUSI_TradeName	,BUSI.BUSI_Address1		,BUSI_Address2
			,BUSI_Urbanization		,BUSI_Email				,BUSI_Web
			,BUSI_SocialNetworks	,BUSI_PhoneNumber1		,BUSI_PhoneNumber2
			,BUSI_BankAccount		
			,UDEP.UBIG_Description AS BUSI_Departamento
			,UPRO.UBIG_Description AS BUSI_Provincia
			,UDIS.UBIG_Description AS BUSI_Distrito
	FROM dbo.VENPY_Business AS BUSI
	INNER JOIN #TMP_BranchOfficesUsers AS TBUSI ON TBUSI.BUSI_Code = BUSI.BUSI_Code
	INNER JOIN dbo.VENPY_Ubigeos AS UDEP ON UDEP.UBIG_Code = SUBSTRING(BUSI.UBIG_Code,1,2)
	INNER JOIN dbo.VENPY_Ubigeos AS UPRO ON UPRO.UBIG_Code = SUBSTRING(BUSI.UBIG_Code,1,5)
	INNER JOIN dbo.VENPY_Ubigeos AS UDIS ON UDIS.UBIG_Code = BUSI.UBIG_Code
	WHERE 
	TBUSI.USER_Code = @pintUSER_Code AND 
	BUSI.BUSI_RUC LIKE '%' + ISNULL(@pvchBUSI_RUC,'') + '%' AND 
	BUSI.BUSI_BusinessName LIKE '%' + ISNULL(@pvchBUSI_BusinessName,'') + '%' 

END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BUSII_ACompany]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[BUSII_ACompany]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[BUSII_ACompany]
( 
	 @pintBUSI_Code				INT 
	,@pvchBUSI_RUC				VARCHAR(11)
	,@pvchBUSI_BusinessName		VARCHAR(100) 
	,@pvchBUSI_TradeName		VARCHAR(100) 
	,@pvchBUSI_Address1			VARCHAR(100) 
	,@pvchBUSI_Address2			VARCHAR(100) 
	,@pvchBUSI_Urbanization		VARCHAR(50) 
	,@pvchBUSI_Email			VARCHAR(150)
	,@pvchBUSI_Web				VARCHAR(100)
	,@pvchBUSI_SocialNetworks	VARCHAR(250) 
	,@pvchBUSI_PhoneNumber1		VARCHAR(25) 
	,@pvchBUSI_PhoneNumber2		VARCHAR(25) 
	,@pvchBUSI_BankAccount		VARCHAR(20)
	,@pvchUBIG_Code				VARCHAR(20) 
	,@pvchAUDI_CreationUser		VARCHAR(20) 
	,@pvchBUSI_ErrorMessage		VARCHAR(MAX) OUTPUT
) 
AS 
BEGIN

	IF NOT EXISTS (SELECT BUSI_Code FROM dbo.VENPY_Business WHERE BUSI_RUC = @pvchBUSI_RUC OR RTRIM(LTRIM(BUSI_BusinessName)) = RTRIM(LTRIM(@pvchBUSI_BusinessName)) )
	BEGIN
		SET @pintBUSI_Code = ISNULL((SELECT MAX(BUSI_Code) FROM dbo.VENPY_Business)+ 1,1)
		INSERT INTO [VENPY_Business]
		    ( BUSI_Code			, BUSI_RUC				, BUSI_BusinessName		, BUSI_TradeName
		    , BUSI_Address1		, BUSI_Address2			, BUSI_Urbanization		, BUSI_Email
		    , BUSI_Web			, BUSI_SocialNetworks	, BUSI_PhoneNumber1		, BUSI_PhoneNumber2
		    , BUSI_BankAccount	, UBIG_Code				, AUDI_CreationUser		, AUDI_CreationDate )
		VALUES
		    ( @pintBUSI_Code		, @pvchBUSI_RUC				, @pvchBUSI_BusinessName	, @pvchBUSI_TradeName
		    , @pvchBUSI_Address1	, @pvchBUSI_Address2		, @pvchBUSI_Urbanization	, @pvchBUSI_Email
		    , @pvchBUSI_Web			, @pvchBUSI_SocialNetworks	, @pvchBUSI_PhoneNumber1	, @pvchBUSI_PhoneNumber2
		    , @pvchBUSI_BankAccount	, @pvchUBIG_Code			, @pvchAUDI_CreationUser	, GETDATE() )
	END
	ELSE
	BEGIN 
		SET @pvchBUSI_ErrorMessage = 'Ya existe una Empresa con el mismo número de RUC y/o Razón Social'
	END
END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BUSIU_ACompany]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[BUSIU_ACompany]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[BUSIU_ACompany]
( 
	 @pintBUSI_Code				INT 
	,@pvchBUSI_RUC				VARCHAR(11)
	,@pvchBUSI_BusinessName		VARCHAR(100) 
	,@pvchBUSI_TradeName		VARCHAR(100) 
	,@pvchBUSI_Address1			VARCHAR(100) 
	,@pvchBUSI_Address2			VARCHAR(100) 
	,@pvchBUSI_Urbanization		VARCHAR(50) 
	,@pvchBUSI_Email			VARCHAR(150)
	,@pvchBUSI_Web				VARCHAR(100)
	,@pvchBUSI_SocialNetworks	VARCHAR(250) 
	,@pvchBUSI_PhoneNumber1		VARCHAR(25) 
	,@pvchBUSI_PhoneNumber2		VARCHAR(25) 
	,@pvchBUSI_BankAccount		VARCHAR(20)
	,@pvchUBIG_Code				VARCHAR(20) 
	,@pvchAUDI_ModificationUser VARCHAR(20)
	,@pvchBUSI_ErrorMessage		VARCHAR(MAX) OUTPUT
) 
AS 
BEGIN
	IF NOT EXISTS (SELECT BUSI_Code FROM dbo.VENPY_Business WHERE (BUSI_RUC = @pvchBUSI_RUC OR RTRIM(LTRIM(BUSI_BusinessName)) = RTRIM(LTRIM(@pvchBUSI_BusinessName))) AND BUSI_Code <> @pintBUSI_Code)
	BEGIN
		UPDATE [VENPY_Business]
			SET 
				 [BUSI_RUC]					= @pvchBUSI_RUC
				,[BUSI_BusinessName]		= @pvchBUSI_BusinessName
				,[BUSI_TradeName]			= @pvchBUSI_TradeName
				,[BUSI_Address1]			= @pvchBUSI_Address1
				,[BUSI_Address2]			= @pvchBUSI_Address2
				,[BUSI_Urbanization]		= @pvchBUSI_Urbanization
				,[BUSI_Email]				= @pvchBUSI_Email
				,[BUSI_Web]					= @pvchBUSI_Web
				,[BUSI_SocialNetworks]		= @pvchBUSI_SocialNetworks
				,[BUSI_PhoneNumber1]		= @pvchBUSI_PhoneNumber1
				,[BUSI_PhoneNumber2]		= @pvchBUSI_PhoneNumber2
				,[BUSI_BankAccount]			= @pvchBUSI_BankAccount
				,[UBIG_Code]				= @pvchUBIG_Code
				,[AUDI_ModificationUser]	= @pvchAUDI_ModificationUser
				,[AUDI_ModificationDate]	= GETDATE()
		WHERE [BUSI_Code] = @pintBUSI_Code
	END
	ELSE
	BEGIN 
		SET @pvchBUSI_ErrorMessage = 'Ya existe un Empresa con el mismo número de RUC y/o Razón Social'
	END
END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BUSIS_ACompany]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[BUSIS_ACompany]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[BUSIS_ACompany]
( 
	 @pintBUSI_Code		INT 
) 
AS 
BEGIN

	SELECT	 BUSI.BUSI_Code				,BUSI.BUSI_RUC			,BUSI.BUSI_BusinessName
			,BUSI.BUSI_TradeName		,BUSI.BUSI_Address1		,BUSI.BUSI_Address2
			,BUSI.BUSI_Urbanization		,BUSI.BUSI_Email		,BUSI.BUSI_Web
			,BUSI.BUSI_SocialNetworks	,BUSI.BUSI_PhoneNumber1	,BUSI.BUSI_PhoneNumber2
			,BUSI.BUSI_BankAccount		,BUSI.UBIG_Code	 
			,SUBSTRING(BUSI.UBIG_Code,1,2) AS BUSI_CodeDepartamento
			,SUBSTRING(BUSI.UBIG_Code,1,5) AS BUSI_CodeProvincia
			,BUSI.UBIG_Code AS BUSI_CodeDistrito
	FROM dbo.VENPY_Business AS BUSI
	WHERE 
	BUSI.BUSI_Code = @pintBUSI_Code

END
GO 