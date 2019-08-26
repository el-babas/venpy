
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PRODS_ListProducts]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[PRODS_ListProducts]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[PRODS_ListProducts]
(	 
	 @pintBUSI_Code			INT
	,@pvchTBLE_TableFAP		VARCHAR(3) 
	,@pvchTBLE_CodeFAP		VARCHAR(6) 
	,@pvchTBLE_TableMAR		VARCHAR(3) 
	,@pvchTBLE_CodeMAR		VARCHAR(6) 
	,@pvchPROD_Name			VARCHAR(50)
) 
AS
BEGIN	

	SELECT	 PROD.BUSI_Code		,PROD.PROD_Code		,PROD.PROD_Active	,PROD.TBLE_TableFAP
			,PROD.TBLE_CodeFAP	,PROD.TBLE_TableUNM	,PROD.TBLE_CodeUNM	,PROD.PROD_Name
			,PROD.PROD_Original	,PROD.TBLE_TableMAR	,PROD.TBLE_CodeMAR
			,TFAP.TBLE_Description1 AS TBLE_NameFAP 
			,TUNM.TBLE_Description1 AS TBLE_NameUNM 
			,ISNULL(TMAR.TBLE_Description1,'SIN MARCA') AS TBLE_NameMAR 
	FROM VENPY_Products AS PROD
	LEFT JOIN dbo.VENPY_Tables AS TFAP ON	TFAP.BUSI_Code = PROD.BUSI_Code AND 
											TFAP.TBLE_Table = PROD.TBLE_TableFAP AND 
											TFAP.TBLE_Code = PROD.TBLE_CodeFAP
	LEFT JOIN dbo.VENPY_Tables AS TUNM ON	TUNM.BUSI_Code = PROD.BUSI_Code AND 
											TUNM.TBLE_Table = PROD.TBLE_TableUNM AND 
											TUNM.TBLE_Code = PROD.TBLE_CodeUNM
	LEFT JOIN dbo.VENPY_Tables AS TMAR ON	TMAR.BUSI_Code = PROD.BUSI_Code AND 
											TMAR.TBLE_Table = PROD.TBLE_TableMAR AND 
											TMAR.TBLE_Code = PROD.TBLE_CodeMAR
	WHERE 
	PROD.BUSI_Code = @pintBUSI_Code AND 
	PROD.TBLE_TableFAP = @pvchTBLE_TableFAP AND
	PROD.TBLE_CodeFAP = @pvchTBLE_CodeFAP AND 
	PROD.TBLE_TableMAR = ISNULL(@pvchTBLE_TableMAR, PROD.TBLE_TableMAR) AND 
	PROD.TBLE_CodeMAR = ISNULL(@pvchTBLE_CodeMAR, PROD.TBLE_CodeMAR) AND
	PROD.PROD_Name LIKE '%' + ISNULL(@pvchPROD_Name, '') + '%'

END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PRODS_AProduct]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[PRODS_AProduct]

GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[PRODS_AProduct]
( 
	 @pintBUSI_Code		INT 
	,@pintPROD_Code		INT 
) 
AS
BEGIN

   SELECT	 PROD.BUSI_Code		,PROD.PROD_Code		,PROD.PROD_Active	,PROD.TBLE_TableFAP
			,PROD.TBLE_CodeFAP	,PROD.TBLE_TableUNM	,PROD.TBLE_CodeUNM	,PROD.PROD_Name
			,PROD.PROD_Original	,PROD.TBLE_TableMAR	,PROD.TBLE_CodeMAR	,PROD.PROD_Description
			,PROD.PROD_Model	,PROD.PROD_Serie
	FROM VENPY_Products AS PROD
	WHERE 
	PROD.BUSI_Code= @pintBUSI_Code AND 
	PROD.PROD_Code= @pintPROD_Code

END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PRODI_AProduct]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[PRODI_AProduct]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[PRODI_AProduct]
(	 
	 @pintBUSI_Code				INT 
	,@pintPROD_Code				INT OUTPUT
	,@pbitPROD_Active			BIT
	,@pvchTBLE_TableFAP			VARCHAR(3) 
	,@pvchTBLE_CodeFAP			VARCHAR(6) 
	,@pvchTBLE_TableUNM			VARCHAR(3) 
	,@pvchTBLE_CodeUNM			VARCHAR(6) 
	,@pvchPROD_Name				VARCHAR(50)
	,@pvchPROD_Description		VARCHAR(100)
	,@pbitPROD_Original			BIT
	,@pvchTBLE_TableMAR			VARCHAR(3)
	,@pvchTBLE_CodeMAR			VARCHAR(6)
	,@pvchPROD_Model			VARCHAR(50)
	,@pvchPROD_Serie			VARCHAR(50)
	,@pvchAUDI_CreationUser		VARCHAR(20)
) 
AS 
BEGIN

	SET @pintPROD_Code = ISNULL((SELECT MAX(PROD_Code) FROM [dbo].[VENPY_Products] WHERE BUSI_Code = @pintBUSI_Code ) + 1,1)
	INSERT INTO [VENPY_Products]
		( BUSI_Code			, PROD_Code		, PROD_Active		, TBLE_TableFAP
		, TBLE_CodeFAP		, TBLE_TableUNM	, TBLE_CodeUNM		, PROD_Name
		, PROD_Description	, PROD_Original	, TBLE_TableMAR		, TBLE_CodeMAR
		, PROD_Model		, PROD_Serie	, AUDI_CreationUser , AUDI_CreationDate )  
	VALUES
		( @pintBUSI_Code		, @pintPROD_Code		, @pbitPROD_Active			, @pvchTBLE_TableFAP
		, @pvchTBLE_CodeFAP		, @pvchTBLE_TableUNM	, @pvchTBLE_CodeUNM			, @pvchPROD_Name
		, @pvchPROD_Description	, @pbitPROD_Original	, @pvchTBLE_TableMAR		, @pvchTBLE_CodeMAR
		, @pvchPROD_Model		, @pvchPROD_Serie		, @pvchAUDI_CreationUser	, GETDATE())

END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PRODU_AProduct]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[PRODU_AProduct]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[PRODU_AProduct]
( 
	 @pintBUSI_Code				INT 
	,@pintPROD_Code				INT OUTPUT
	,@pbitPROD_Active			BIT
	,@pvchTBLE_TableFAP			VARCHAR(3) 
	,@pvchTBLE_CodeFAP			VARCHAR(6) 
	,@pvchTBLE_TableUNM			VARCHAR(3) 
	,@pvchTBLE_CodeUNM			VARCHAR(6) 
	,@pvchPROD_Name				VARCHAR(50)
	,@pvchPROD_Description		VARCHAR(100)
	,@pbitPROD_Original			BIT
	,@pvchTBLE_TableMAR			VARCHAR(3)
	,@pvchTBLE_CodeMAR			VARCHAR(6)
	,@pvchPROD_Model			VARCHAR(50)
	,@pvchPROD_Serie			VARCHAR(50)
	,@pvchAUDI_ModificationUser VARCHAR(20) 
) 
AS 
BEGIN

	UPDATE	[VENPY_Products]
		SET [PROD_Active]			= @pbitPROD_Active
		  , [TBLE_TableFAP]			= @pvchTBLE_TableFAP
		  , [TBLE_CodeFAP]			= @pvchTBLE_CodeFAP
		  , [TBLE_TableUNM]			= @pvchTBLE_TableUNM
		  , [TBLE_CodeUNM]			= @pvchTBLE_CodeUNM
		  , [PROD_Name]				= @pvchPROD_Name
		  , [PROD_Description]		= @pvchPROD_Description
		  , [PROD_Original]			= @pbitPROD_Original
		  , [TBLE_TableMAR]			= @pvchTBLE_TableMAR
		  , [TBLE_CodeMAR]			= @pvchTBLE_CodeMAR
		  , [PROD_Model]			= @pvchPROD_Model
		  , [PROD_Serie]			= @pvchPROD_Serie
		  , [AUDI_ModificationUser] = @pvchAUDI_ModificationUser
		  , [AUDI_ModificationDate] = GETDATE()
	WHERE 
	[BUSI_Code] = @pintBUSI_Code AND 
	[PROD_Code] = @pintPROD_Code

END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PRODD_AProduct]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[PRODD_AProduct]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[PRODD_AProduct]
( 
	 @pintBUSI_Code		INT
	,@pintPROD_Code		INT
) 
AS 
BEGIN

	DELETE FROM [dbo].[VENPY_MeasurementUnitsProducts]
	WHERE 
	[BUSI_Code] = @pintBUSI_Code AND 
	[PROD_Code] = @pintPROD_Code

	DELETE FROM [VENPY_Products]
	WHERE 
	[BUSI_Code] = @pintBUSI_Code AND 
	[PROD_Code] = @pintPROD_Code

END
GO