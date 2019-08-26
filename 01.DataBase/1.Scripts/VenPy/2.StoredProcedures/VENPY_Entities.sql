IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ENTIS_ListEntities]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[ENTIS_ListEntities]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[ENTIS_ListEntities]
(	 
	 @pintBUSI_Code				INT 
	,@pintETYP_Code				INT 
	,@pvchENTI_DocumentNumber	VARCHAR(20)
	,@pvchENTI_BusinessName		VARCHAR(100) 
	,@pbitENTI_Favourite		BIT
) 
AS
BEGIN
	
	SELECT 
	 ENTI.BUSI_Code				,ENTI.ENTI_Code		,ENTI.TBLE_TableTDI		,ENTI.TBLE_CodeTDI 
	,ENTI.ENTI_DocumentNumber	,ENTI.ENTI_Address	,ENTI.UBIG_Code			,ENTI.ENTI_Favourite
	,ENTI.ENTI_BusinessName		,ENTI.ENTI_Domiciled
	,TTDI.TBLE_Description1 AS TBLE_NameTDI 
	,UDEP.UBIG_Description AS ENTI_Departamento 
	,UPRO.UBIG_Description AS ENTI_Provincia 
	,UDIS.UBIG_Description AS ENTI_Distrito 
	,CASE ENTI.ENTI_Status	WHEN 'A' THEN 'ACTIVO'
							WHEN 'I' THEN 'INACTIVO'
							WHEN 'D' THEN 'DESHABILITADO'
							WHEN 'N' THEN 'NO HABIDO'
							WHEN 'B' THEN 'BLOQUEADO'
							ELSE 'SIN ESTADO' END AS ENTI_NameStatus 
	FROM dbo.VENPY_Entities AS ENTI
	INNER JOIN dbo.VENPY_FunctionsEntities AS FENT ON	FENT.BUSI_Code = ENTI.BUSI_Code AND 
														FENT.ENTI_Code = ENTI.ENTI_Code AND 
														FENT.ETYP_Code = @pintETYP_Code
	INNER JOIN dbo.VENPY_Tables AS TTDI ON	TTDI.BUSI_Code = ENTI.BUSI_Code AND 
											TTDI.TBLE_Table = ENTI.TBLE_TableTDI AND 
											TTDI.TBLE_Code = ENTI.TBLE_CodeTDI
	LEFT JOIN dbo.VENPY_Ubigeos AS UDEP ON UDEP.UBIG_Code = SUBSTRING(ENTI.UBIG_Code,1,2)
	LEFT JOIN dbo.VENPY_Ubigeos AS UPRO ON UPRO.UBIG_Code = SUBSTRING(ENTI.UBIG_Code,1,5)
	LEFT JOIN dbo.VENPY_Ubigeos AS UDIS ON UDIS.UBIG_Code = ENTI.UBIG_Code
	WHERE 
	ENTI.BUSI_Code = @pintBUSI_Code AND	
	ENTI.ENTI_Favourite = CASE ISNULL(@pbitENTI_Favourite,0) WHEN 0 THEN ENTI.ENTI_Favourite ELSE 1 END  AND 
	ENTI.ENTI_DocumentNumber LIKE '%' + ISNULL(@pvchENTI_DocumentNumber,'') +'%' AND 
	ENTI.ENTI_BusinessName LIKE '%' + ISNULL(@pvchENTI_BusinessName,'') +'%'		

END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ENTIS_Help]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[ENTIS_Help]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[ENTIS_Help]
(	 
	 @pintBUSI_Code				INT 
	,@pintETYP_Code				INT 
	,@pvchENTI_DocumentNumber	VARCHAR(20)
	,@pvchENTI_BusinessName		VARCHAR(100) 
) 
AS
BEGIN
	
	SELECT 
	 ENTI.BUSI_Code				,ENTI.ENTI_Code		,ENTI.TBLE_TableTDI		,ENTI.TBLE_CodeTDI 
	,ENTI.ENTI_DocumentNumber	,ENTI.ENTI_BusinessName		
	,TTDI.TBLE_Description1 AS TBLE_NameTDI 
	FROM dbo.VENPY_Entities AS ENTI
	INNER JOIN dbo.VENPY_FunctionsEntities AS FENT ON	FENT.BUSI_Code = ENTI.BUSI_Code AND 
														FENT.ENTI_Code = ENTI.ENTI_Code AND 
														FENT.ETYP_Code = @pintETYP_Code
	INNER JOIN dbo.VENPY_Tables AS TTDI ON	TTDI.BUSI_Code = ENTI.BUSI_Code AND 
											TTDI.TBLE_Table = ENTI.TBLE_TableTDI AND 
											TTDI.TBLE_Code = ENTI.TBLE_CodeTDI
	WHERE 
	ENTI.BUSI_Code = @pintBUSI_Code AND	
	ENTI.ENTI_Status = 'A' AND 
	ENTI.ENTI_DocumentNumber LIKE ISNULL(@pvchENTI_DocumentNumber,'') +'%' AND 
	ENTI.ENTI_BusinessName LIKE ISNULL(@pvchENTI_BusinessName,'') +'%'		

END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ENTIS_AEntity]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[ENTIS_AEntity]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[ENTIS_AEntity]
(	 
	 @pintBUSI_Code				INT 
	,@pintENTI_Code				INT 
) 
AS
BEGIN
	
	SELECT
	 ENTI.BUSI_Code			,ENTI.ENTI_Code					,ENTI.TBLE_TableTDI			,ENTI.TBLE_CodeTDI 
    ,ENTI.ENTI_EntityType	,ENTI.ENTI_DocumentNumber		,ENTI.ENTI_BusinessName		,ENTI.ENTI_Birthdate 
    ,ENTI.ENTI_Address		,ENTI.UBIG_Code					,ENTI.ENTI_Email			,ENTI.ENTI_Web					
	,ENTI.ENTI_PhoneNumber	,ENTI.ENTI_ReferentialAddress	,ENTI.ENTI_Domiciled		,ENTI.ENTI_Status 
    ,ENTI.TBLE_TablePAI		,ENTI.TBLE_CodePAI				,ENTI.ENTI_Favourite		,ENTI.ENTI_BankAccount		
	,SUBSTRING(ENTI.UBIG_Code,1,2) AS ENTI_CodeDepartamento
	,SUBSTRING(ENTI.UBIG_Code,1,5) AS ENTI_CodeProvincia
	,ENTI.UBIG_Code AS ENTI_CodeDistrito
	FROM dbo.VENPY_Entities AS ENTI
	WHERE
	ENTI.BUSI_Code = @pintBUSI_Code AND 
	ENTI.ENTI_Code = @pintENTI_Code

END
GO


IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ENTII_AEntity]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[ENTII_AEntity]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[ENTII_AEntity]
( 
	 @pintBUSI_Code					INT  
	,@pintENTI_Code					INT OUTPUT
	,@pvchTBLE_TableTDI				VARCHAR(3) 
	,@pvchTBLE_CodeTDI				VARCHAR(6) 
	,@pchrENTI_EntityType			CHAR(1) 
	,@pvchENTI_DocumentNumber		VARCHAR(20) 
	,@pvchENTI_BusinessName			VARCHAR(100) 
	,@pdteENTI_Birthdate			DATE 
	,@pvchENTI_Address				VARCHAR(200) 
	,@pvchUBIG_Code					VARCHAR(20) 
	,@pvchENTI_Email				VARCHAR(150) 
	,@pvchENTI_Web					VARCHAR(100) 
	,@pvchENTI_PhoneNumber			VARCHAR(50) 
	,@pvchENTI_ReferentialAddress	VARCHAR(100) 
	,@pbitENTI_Domiciled			BIT 
	,@pvchTBLE_TablePAI				VARCHAR(3) 
	,@pvchTBLE_CodePAI				VARCHAR(6) 
	,@pbitENTI_Favourite			BIT 
	,@pvchENTI_BankAccount			VARCHAR(20) 
	,@pchrENTI_Status				CHAR(1) 
	,@pvchAUDI_CreationUser			VARCHAR(20) 
	,@pvchENTI_ErrorMessage			VARCHAR(MAX) OUTPUT
) 
AS 
BEGIN

	IF NOT EXISTS (SELECT ENTI_Code FROM [VENPY_Entities] 
					WHERE BUSI_Code = @pintBUSI_Code 
					AND	 (RTRIM(LTRIM(ENTI_BusinessName)) = RTRIM(LTRIM(@pvchENTI_BusinessName)) OR RTRIM(LTRIM(ENTI_DocumentNumber)) = RTRIM(LTRIM(@pvchENTI_DocumentNumber))))
	BEGIN
		SET @pintENTI_Code = ISNULL((SELECT MAX(ENTI_Code) FROM [VENPY_Entities] WHERE BUSI_Code = @pintBUSI_Code ) + 1,1)
		INSERT INTO [VENPY_Entities]
		     ( BUSI_Code			, ENTI_Code					, TBLE_TableTDI			, TBLE_CodeTDI
		     , ENTI_EntityType		, ENTI_DocumentNumber		, ENTI_BusinessName		, ENTI_Birthdate
		     , ENTI_Address			, UBIG_Code					, ENTI_Email			, ENTI_Web		
			 , ENTI_PhoneNumber		, ENTI_ReferentialAddress	, ENTI_Domiciled		, TBLE_TablePAI		
			 , TBLE_CodePAI			, ENTI_Favourite			, ENTI_BankAccount		, ENTI_Status
		     , AUDI_CreationUser	, AUDI_CreationDate )
		VALUES
		     ( @pintBUSI_Code			, @pintENTI_Code				, @pvchTBLE_TableTDI		, @pvchTBLE_CodeTDI
		     , @pchrENTI_EntityType		, @pvchENTI_DocumentNumber		, @pvchENTI_BusinessName	, @pdteENTI_Birthdate
		     , @pvchENTI_Address		, @pvchUBIG_Code				, @pvchENTI_Email			, @pvchENTI_Web					
			 , @pvchENTI_PhoneNumber	, @pvchENTI_ReferentialAddress	, @pbitENTI_Domiciled		, @pvchTBLE_TablePAI		
			 , @pvchTBLE_CodePAI		, @pbitENTI_Favourite			, @pvchENTI_BankAccount		, @pchrENTI_Status
		     , @pvchAUDI_CreationUser	, GETDATE() )
	END 
	ELSE
    BEGIN 
		SET @pvchENTI_ErrorMessage = 'Ya existe una Entidad con el nombre ' + @pvchENTI_BusinessName + ' o el Numero de Documento ' + @pvchENTI_DocumentNumber
	END

END
GO


IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ENTIU_AEntity]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[ENTIU_AEntity]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[ENTIU_AEntity]
( 
	 @pintBUSI_Code					INT  
	,@pintENTI_Code					INT  
	,@pvchTBLE_TableTDI				VARCHAR(3) 
	,@pvchTBLE_CodeTDI				VARCHAR(6) 
	,@pchrENTI_EntityType			CHAR(1) 
	,@pvchENTI_DocumentNumber		VARCHAR(20) 
	,@pvchENTI_BusinessName			VARCHAR(100) 
	,@pdteENTI_Birthdate			DATE 
	,@pvchENTI_Address				VARCHAR(200) 
	,@pvchUBIG_Code					VARCHAR(20) 
	,@pvchENTI_Email				VARCHAR(150) 
	,@pvchENTI_Web					VARCHAR(100) 
	,@pvchENTI_PhoneNumber			VARCHAR(50) 
	,@pvchENTI_ReferentialAddress	VARCHAR(100) 
	,@pbitENTI_Domiciled			BIT 
	,@pvchTBLE_TablePAI				VARCHAR(3) 
	,@pvchTBLE_CodePAI				VARCHAR(6) 
	,@pbitENTI_Favourite			BIT 
	,@pvchENTI_BankAccount			VARCHAR(20) 
	,@pchrENTI_Status				CHAR(1) 
	,@pvchAUDI_ModificationUser		VARCHAR(20) 
	,@pvchENTI_ErrorMessage			VARCHAR(MAX) OUTPUT
) 
AS 
BEGIN

	IF NOT EXISTS (SELECT ENTI_Code FROM [VENPY_Entities] 
					WHERE BUSI_Code = @pintBUSI_Code 
					AND	 (RTRIM(LTRIM(ENTI_BusinessName)) = RTRIM(LTRIM(@pvchENTI_BusinessName)) OR RTRIM(LTRIM(ENTI_DocumentNumber)) = RTRIM(LTRIM(@pvchENTI_DocumentNumber)))
					AND	  ENTI_Code <> @pintENTI_Code)
	BEGIN
		UPDATE [VENPY_Entities]
		   SET [TBLE_TableTDI]				= @pvchTBLE_TableTDI
		     , [TBLE_CodeTDI]				= @pvchTBLE_CodeTDI
		     , [ENTI_EntityType]			= @pchrENTI_EntityType
		     , [ENTI_DocumentNumber]		= @pvchENTI_DocumentNumber
		     , [ENTI_BusinessName]			= @pvchENTI_BusinessName
		     , [ENTI_Birthdate]				= @pdteENTI_Birthdate
		     , [ENTI_Address]				= @pvchENTI_Address
		     , [UBIG_Code]					= @pvchUBIG_Code
		     , [ENTI_Email]					= @pvchENTI_Email
		     , [ENTI_Web]					= @pvchENTI_Web
		     , [ENTI_PhoneNumber]			= @pvchENTI_PhoneNumber
		     , [ENTI_ReferentialAddress]	= @pvchENTI_ReferentialAddress
		     , [ENTI_Domiciled]				= @pbitENTI_Domiciled
		     , [TBLE_TablePAI]				= @pvchTBLE_TablePAI
		     , [TBLE_CodePAI]				= @pvchTBLE_CodePAI
		     , [ENTI_Favourite]				= @pbitENTI_Favourite
		     , [ENTI_BankAccount]			= @pvchENTI_BankAccount
		     , [ENTI_Status]				= @pchrENTI_Status
		     , [AUDI_ModificationUser]		= @pvchAUDI_ModificationUser
		     , [AUDI_ModificationDate]		= GETDATE()
		WHERE 
		[BUSI_Code] = @pintBUSI_Code AND 
		[ENTI_Code] = @pintENTI_Code

	END 
	ELSE
    BEGIN 
		SET @pvchENTI_ErrorMessage = 'Ya existe una Entidad con el nombre ' + @pvchENTI_BusinessName + ' o el Numero de Documento ' + @pvchENTI_DocumentNumber
	END

END
GO


IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ENTID_AEntity]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[ENTID_AEntity]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[ENTID_AEntity]
( 
	 @pintBUSI_Code int = NULL
	,@pintENTI_Code int = NULL 
) AS 
BEGIN

	DELETE FROM [dbo].[VENPY_FunctionsEntities]
	WHERE 
	[BUSI_Code] = @pintBUSI_Code AND 
	[ENTI_Code] = @pintENTI_Code

	DELETE FROM [VENPY_Entities]
    WHERE 
	[BUSI_Code] = @pintBUSI_Code AND 
	[ENTI_Code] = @pintENTI_Code

END
GO