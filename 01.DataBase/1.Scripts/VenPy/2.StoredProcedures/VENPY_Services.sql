IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SERVS_ListServices]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[SERVS_ListServices]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[SERVS_ListServices]
(	 
	 @pintBUSI_Code			INT
	,@pvchTBLE_TableFAS		VARCHAR(3) 
	,@pvchTBLE_CodeFAS		VARCHAR(6) 
	,@pvchSERV_Name			VARCHAR(50)
) 
AS
BEGIN	

	SELECT	 SERV.BUSI_Code			,SERV.SERV_Code		,SERV.SERV_Active	,SERV.SERV_Name
			,SERV.TBLE_TableFAS		,SERV.TBLE_CodeFAS	,SERV.TBLE_TableMND	,SERV.TBLE_CodeMND 
			,TFAS.TBLE_Description1 AS TBLE_NameFAS 
			,TMND.TBLE_Description1 AS TBLE_NameMND 
	FROM [dbo].[VENPY_Services] AS SERV
	LEFT JOIN [dbo].[VENPY_Tables] AS TFAS ON	TFAS.BUSI_Code = SERV.BUSI_Code AND 
											TFAS.TBLE_Table = SERV.TBLE_TableFAS AND 
											TFAS.TBLE_Code = SERV.TBLE_CodeFAS
	LEFT JOIN [dbo].[VENPY_Tables] AS TMND ON	TMND.BUSI_Code = SERV.BUSI_Code AND 
											TMND.TBLE_Table = SERV.TBLE_TableMND AND 
											TMND.TBLE_Code = SERV.TBLE_CodeMND
	WHERE 
	SERV.BUSI_Code = @pintBUSI_Code AND 
	SERV.TBLE_TableFAS = @pvchTBLE_TableFAS AND
	SERV.TBLE_CodeFAS = @pvchTBLE_CodeFAS AND 
	SERV.SERV_Name LIKE '%' + ISNULL(@pvchSERV_Name, '') + '%'

END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SERVS_AService]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[SERVS_AService]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[SERVS_AService]
( 
	 @pintBUSI_Code		INT 
	,@pintSERV_Code		INT 
) 
AS
BEGIN

	SELECT	 SERV.BUSI_Code			,SERV.SERV_Code			,SERV.SERV_Active				,SERV.SERV_Name
			,SERV.SERV_Description	,SERV.TBLE_TableFAS		,SERV.TBLE_CodeFAS				,SERV.TBLE_TableUNM
			,SERV.TBLE_CodeUNM		,SERV.TBLE_TableTAI		,SERV.TBLE_CodeTAI				,SERV.TBLE_TableMND
			,SERV.TBLE_CodeMND		,SERV.SERV_UnitValue	,SERV.SERV_IGV					,SERV.SERV_UnitPrice
			,SERV.AUDI_CreationUser	,SERV.AUDI_CreationDate ,SERV.AUDI_ModificationUser		,SERV.AUDI_ModificationDate
	FROM [dbo].[VENPY_Services] AS SERV
	WHERE 
	SERV.BUSI_Code= @pintBUSI_Code AND 
	SERV.SERV_Code= @pintSERV_Code

END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SERVI_AService]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[SERVI_AService]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[SERVI_AService]
( 
	 @pintBUSI_Code				INT 
	,@pintSERV_Code				INT OUTPUT
	,@pbitSERV_Active			BIT 
	,@pvchSERV_Name				VARCHAR(50) 
	,@pvchSERV_Description		VARCHAR(100) 
	,@pvchTBLE_TableFAS			VARCHAR(3) 
	,@pvchTBLE_CodeFAS			VARCHAR(6) 
	,@pvchTBLE_TableUNM			VARCHAR(3) 
	,@pvchTBLE_CodeUNM			VARCHAR(6) 
	,@pvchTBLE_TableTAI			VARCHAR(3) 
	,@pvchTBLE_CodeTAI			VARCHAR(6) 
	,@pvchTBLE_TableMND			VARCHAR(3) 
	,@pvchTBLE_CodeMND			VARCHAR(6) 
	,@pdecSERV_UnitValue		DECIMAL(20, 8) 
	,@pdecSERV_IGV				DECIMAL(20, 8) 
	,@pdecSERV_UnitPrice		DECIMAL(20, 8) 
	,@pvchAUDI_CreationUser		VARCHAR(20) 
) 
AS 
BEGIN

	SET @pintSERV_Code = ISNULL((SELECT MAX(SERV_Code) FROM [dbo].[VENPY_Services] WHERE BUSI_Code = @pintBUSI_Code ) + 1,1)
	INSERT INTO [VENPY_Services]
		( BUSI_Code			, SERV_Code			, SERV_Active	, SERV_Name
		, SERV_Description	, TBLE_TableFAS		, TBLE_CodeFAS	, TBLE_TableUNM
		, TBLE_CodeUNM		, TBLE_TableTAI		, TBLE_CodeTAI	, TBLE_TableMND
		, TBLE_CodeMND		, SERV_UnitValue	, SERV_IGV		, SERV_UnitPrice
		, AUDI_CreationUser , AUDI_CreationDate )
	VALUES
		( @pintBUSI_Code		, @pintSERV_Code		, @pbitSERV_Active		, @pvchSERV_Name
		, @pvchSERV_Description , @pvchTBLE_TableFAS	, @pvchTBLE_CodeFAS		, @pvchTBLE_TableUNM
		, @pvchTBLE_CodeUNM		, @pvchTBLE_TableTAI	, @pvchTBLE_CodeTAI		, @pvchTBLE_TableMND
		, @pvchTBLE_CodeMND		, @pdecSERV_UnitValue	, @pdecSERV_IGV			, @pdecSERV_UnitPrice
		, @pvchAUDI_CreationUser, GETDATE() )

END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SERVU_AService]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[SERVU_AService]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[SERVU_AService]
( 
	 @pintBUSI_Code				INT 
	,@pintSERV_Code				INT OUTPUT
	,@pbitSERV_Active			BIT 
	,@pvchSERV_Name				VARCHAR(50) 
	,@pvchSERV_Description		VARCHAR(100) 
	,@pvchTBLE_TableFAS			VARCHAR(3) 
	,@pvchTBLE_CodeFAS			VARCHAR(6) 
	,@pvchTBLE_TableUNM			VARCHAR(3) 
	,@pvchTBLE_CodeUNM			VARCHAR(6) 
	,@pvchTBLE_TableTAI			VARCHAR(3) 
	,@pvchTBLE_CodeTAI			VARCHAR(6) 
	,@pvchTBLE_TableMND			VARCHAR(3) 
	,@pvchTBLE_CodeMND			VARCHAR(6) 
	,@pdecSERV_UnitValue		DECIMAL(20, 8) 
	,@pdecSERV_IGV				DECIMAL(20, 8) 
	,@pdecSERV_UnitPrice		DECIMAL(20, 8) 
	,@pvchAUDI_ModificationUser	VARCHAR(20) 
) 
AS 
BEGIN

	UPDATE	 [VENPY_Services]
		SET	 [SERV_Active]				= @pbitSERV_Active
			,[SERV_Name]				= @pvchSERV_Name
			,[SERV_Description]			= @pvchSERV_Description
			,[TBLE_TableFAS]			= @pvchTBLE_TableFAS
			,[TBLE_CodeFAS]				= @pvchTBLE_CodeFAS
			,[TBLE_TableUNM]			= @pvchTBLE_TableUNM
			,[TBLE_CodeUNM]				= @pvchTBLE_CodeUNM
			,[TBLE_TableTAI]			= @pvchTBLE_TableTAI
			,[TBLE_CodeTAI]				= @pvchTBLE_CodeTAI
			,[TBLE_TableMND]			= @pvchTBLE_TableMND
			,[TBLE_CodeMND]				= @pvchTBLE_CodeMND
			,[SERV_UnitValue]			= @pdecSERV_UnitValue
			,[SERV_IGV]					= @pdecSERV_IGV
			,[SERV_UnitPrice]			= @pdecSERV_UnitPrice
			,[AUDI_ModificationUser]	= @pvchAUDI_ModificationUser
			,[AUDI_ModificationDate]	= GETDATE()
    WHERE [BUSI_Code] = @pintBUSI_Code
      AND [SERV_Code] = @pintSERV_Code

END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SERVD_AService]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[SERVD_AService]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[SERVD_AService]
( 
	 @pintBUSI_Code		INT 
	,@pintSERV_Code		INT 
) 
AS
BEGIN

	DELETE FROM [VENPY_Services]
		WHERE 
		[BUSI_Code] = @pintBUSI_Code AND 
		[SERV_Code] = @pintSERV_Code

END
GO