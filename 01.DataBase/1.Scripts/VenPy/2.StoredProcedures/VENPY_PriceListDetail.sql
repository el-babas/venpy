IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PLDES_ByPriceList]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[PLDES_ByPriceList]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[PLDES_ByPriceList]
( 
	 @pintBUSI_Code		INT 
	,@pintPRLI_Code		INT 
) 
AS
BEGIN

	SELECT 
		 PLDE.BUSI_Code			,PLDE.PRLI_Code		,PLDE.PLDE_Item			,PLDE.PROD_Code 
		,PLDE.TBLE_TableUNM		,PLDE.TBLE_CodeUNM	,PLDE.TBLE_TableTAI		,PLDE.TBLE_CodeTAI 
		,PLDE.PLDE_UnitValue	,PLDE.PLDE_IGV		,PLDE.PLDE_UnitPrice	,PROD.PROD_Name
		,TUNM.TBLE_Description1 AS TBLE_NameUNM
	INTO #TMP_PriceListDetail
	FROM [dbo].[VENPY_PriceListDetail] AS PLDE
	INNER JOIN [dbo].[VENPY_Products] AS PROD ON PROD.BUSI_Code = PLDE.BUSI_Code AND PROD.PROD_Code = PLDE.PROD_Code
	INNER JOIN [dbo].[VENPY_Tables] AS TUNM ON TUNM.BUSI_Code = PLDE.BUSI_Code AND TUNM.TBLE_Table = PLDE.TBLE_TableUNM AND TUNM.TBLE_Code = PLDE.TBLE_CodeUNM
	WHERE 
	PLDE.BUSI_Code = @pintBUSI_Code AND 
	PLDE.PRLI_Code = @pintPRLI_Code

	INSERT INTO #TMP_PriceListDetail
	SELECT 
		 @pintBUSI_Code AS BUSI_Code
		,ISNULL(@pintPRLI_Code,0) AS PRLI_Code
		,0 AS PLDE_Item
		,MUPR.PROD_Code AS PROD_Code
		,MUPR.TBLE_TableUNM AS TBLE_TableUNM
		,MUPR.TBLE_CodeUNM AS TBLE_CodeUNM
		,'TAI' AS TBLE_TableTAI
		,'0' AS TBLE_CodeTAI
		,0 AS PLDE_UnitValue
		,0 AS PLDE_IGV
		,0 AS PLDE_UnitPrice
		,PROD.PROD_Name AS PROD_Name
		,TUNM.TBLE_Description1 AS TBLE_NameUNM
	FROM [dbo].[VENPY_MeasurementUnitsProducts] AS MUPR 
	LEFT JOIN #TMP_PriceListDetail AS PLDE ON PLDE.BUSI_Code = MUPR.BUSI_Code AND PLDE.PROD_Code = MUPR.PROD_Code AND 
											  PLDE.TBLE_CodeUNM = MUPR.TBLE_CodeUNM AND PLDE.TBLE_TableUNM = MUPR.TBLE_TableUNM
	INNER JOIN [dbo].[VENPY_Products] AS PROD ON PROD.BUSI_Code = MUPR.BUSI_Code AND PROD.PROD_Code = MUPR.PROD_Code
	INNER JOIN [dbo].[VENPY_Tables] AS TUNM ON TUNM.BUSI_Code = MUPR.BUSI_Code AND TUNM.TBLE_Table = MUPR.TBLE_TableUNM AND TUNM.TBLE_Code = MUPR.TBLE_CodeUNM
	WHERE 
	MUPR.BUSI_Code = @pintBUSI_Code AND
	PLDE.BUSI_Code IS NULL AND 
    PLDE.PROD_Code IS NULL AND 
    PLDE.TBLE_TableUNM IS NULL AND
    PLDE.TBLE_CodeUNM IS NULL

	SELECT * FROM #TMP_PriceListDetail ORDER BY PLDE_Item , PROD_Name
END 
GO 

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PLDEI_APriceListDetail]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[PLDEI_APriceListDetail]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[PLDEI_APriceListDetail]
( 
	 @pintBUSI_Code				INT
	,@pintPRLI_Code				INT
	,@pintPLDE_Item				INT
	,@pintPROD_Code				INT
	,@pvchTBLE_TableUNM			VARCHAR(3) 
	,@pvchTBLE_CodeUNM			VARCHAR(6) 
	,@pvchTBLE_TableTAI			VARCHAR(3) 
	,@pvchTBLE_CodeTAI			VARCHAR(6) 
	,@pdecPLDE_UnitValue		DECIMAL(20, 8)
	,@pdecPLDE_IGV				DECIMAL(20, 8)
	,@pdecPLDE_UnitPrice		DECIMAL(20, 8)
	,@pvchAUDI_CreationUser		VARCHAR(20) 
) 
AS 
BEGIN

	SET @pintPLDE_Item = ISNULL((SELECT MAX(PLDE_Item) FROM [VENPY_PriceListDetail] WHERE BUSI_Code = @pintBUSI_Code AND PRLI_Code = @pintPRLI_Code) + 1,1)
	INSERT INTO [VENPY_PriceListDetail]
		( BUSI_Code			, PRLI_Code		, PLDE_Item			, PROD_Code
		, TBLE_TableUNM		, TBLE_CodeUNM	, TBLE_TableTAI		, TBLE_CodeTAI
		, PLDE_UnitValue	, PLDE_IGV		, PLDE_UnitPrice	, AUDI_CreationUser
		, AUDI_CreationDate )
	VALUES
		( @pintBUSI_Code		, @pintPRLI_Code	, @pintPLDE_Item		, @pintPROD_Code
		, @pvchTBLE_TableUNM	, @pvchTBLE_CodeUNM , @pvchTBLE_TableTAI	, @pvchTBLE_CodeTAI
		, @pdecPLDE_UnitValue	, @pdecPLDE_IGV		, @pdecPLDE_UnitPrice	, @pvchAUDI_CreationUser
		, GETDATE() )

END
GO


IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PLDEU_APriceListDetail]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[PLDEU_APriceListDetail]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[PLDEU_APriceListDetail]
( 
	 @pintBUSI_Code				INT
	,@pintPRLI_Code				INT
	,@pintPLDE_Item				INT
	,@pintPROD_Code				INT
	,@pvchTBLE_TableUNM			VARCHAR(3) 
	,@pvchTBLE_CodeUNM			VARCHAR(6) 
	,@pvchTBLE_TableTAI			VARCHAR(3) 
	,@pvchTBLE_CodeTAI			VARCHAR(6) 
	,@pdecPLDE_UnitValue		DECIMAL(20, 8)
	,@pdecPLDE_IGV				DECIMAL(20, 8)
	,@pdecPLDE_UnitPrice		DECIMAL(20, 8)
	,@pvchAUDI_ModificationUser VARCHAR(20) 

) AS 
BEGIN

	UPDATE [VENPY_PriceListDetail]
		SET [PROD_Code]				= @pintPROD_Code
		  , [TBLE_TableUNM]			= @pvchTBLE_TableUNM
		  , [TBLE_CodeUNM]			= @pvchTBLE_CodeUNM
		  , [TBLE_TableTAI]			= @pvchTBLE_TableTAI
		  , [TBLE_CodeTAI]			= @pvchTBLE_CodeTAI
		  , [PLDE_UnitValue]		= @pdecPLDE_UnitValue
		  , [PLDE_IGV]				= @pdecPLDE_IGV
		  , [PLDE_UnitPrice]		= @pdecPLDE_UnitPrice
		  , [AUDI_ModificationUser] = @pvchAUDI_ModificationUser
		  , [AUDI_ModificationDate] = GETDATE()
	WHERE 
	[BUSI_Code] = @pintBUSI_Code AND 
	[PRLI_Code] = @pintPRLI_Code AND 
	[PLDE_Item] = @pintPLDE_Item

END
GO