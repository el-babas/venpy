IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PFDES_ByProforma]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[PFDES_ByProforma]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[PFDES_ByProforma]
( 
	 @pintBUSI_Code		INT
	,@pintPROF_Code		INT
) 
AS
BEGIN

	SELECT   PFDE.BUSI_Code		,PFDE.PROF_Code		,PFDE.PFDE_Item			,PFDE.PFDE_Type
			,PFDE.TBLE_TableFAP	,PFDE.TBLE_CodeFAP	,PFDE.TBLE_TableFAS		,PFDE.TBLE_CodeFAS
			,PFDE.PROD_Code		,PFDE.SERV_Code		,PFDE.TBLE_TableUNM		,PFDE.TBLE_CodeUNM
			,PFDE.TBLE_TableTAI	,PFDE.TBLE_CodeTAI	,PFDE.PLDE_UnitValue	,PFDE.PLDE_UnitPrice
			,PFDE.PLDE_Quantity	,PFDE.PLDE_IGV		,PFDE.PLDE_ISC			,PFDE.PROF_Discount
	FROM VENPY_ProformaDetails AS PFDE
	WHERE 
	BUSI_Code= @pintBUSI_Code AND 
	PROF_Code= @pintPROF_Code 

END
GO


IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PFDEI_AProformaDetail]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[PFDEI_AProformaDetail]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[PFDEI_AProformaDetail]
( 
	 @pintBUSI_Code				INT OUTPUT
	,@pintPROF_Code				INT OUTPUT
	,@pintPFDE_Item				INT OUTPUT
	,@pchrPFDE_Type				CHAR(1)
	,@pvchTBLE_TableFAP			VARCHAR(3)
	,@pvchTBLE_CodeFAP			VARCHAR(6)
	,@pvchTBLE_TableFAS			VARCHAR(3)
	,@pvchTBLE_CodeFAS			VARCHAR(6)
	,@pintPROD_Code				INT 
	,@pintSERV_Code				INT 
	,@pvchTBLE_TableUNM			VARCHAR(3) 
	,@pvchTBLE_CodeUNM			VARCHAR(6) 
	,@pvchTBLE_TableTAI			VARCHAR(3) 
	,@pvchTBLE_CodeTAI			VARCHAR(6) 
	,@pdecPLDE_UnitValue		DECIMAL(20, 8)
	,@pdecPLDE_UnitPrice		DECIMAL(20, 8)
	,@pdecPLDE_Quantity			DECIMAL(20, 8)
	,@pdecPLDE_IGV				DECIMAL(20, 8)
	,@pdecPLDE_ISC				DECIMAL(20, 8)
	,@pdecPROF_Discount			DECIMAL(20, 8)
	,@pvchAUDI_CreationUser		VARCHAR(20) 
) 
AS 
BEGIN

	SET @pintPFDE_Item = ISNULL((SELECT MAX(PFDE_Item) FROM [dbo].[VENPY_ProformaDetails] WHERE BUSI_Code = @pintBUSI_Code AND PROF_Code = @pintPROF_Code) + 1,1)
	INSERT INTO [VENPY_ProformaDetails]
		(BUSI_Code			,PROF_Code			, PFDE_Item			, PFDE_Type
		,TBLE_TableFAP		,TBLE_CodeFAP		, TBLE_TableFAS		, TBLE_CodeFAS
		,PROD_Code			,SERV_Code			, TBLE_TableUNM		, TBLE_CodeUNM
		,TBLE_TableTAI		,TBLE_CodeTAI		, PLDE_UnitValue	, PLDE_UnitPrice
		,PLDE_Quantity		,PLDE_IGV			, PLDE_ISC			, PROF_Discount
		,AUDI_CreationUser	,AUDI_CreationDate	)
	VALUES
		(@pintBUSI_Code			,@pintPROF_Code		,@pintPFDE_Item			,@pchrPFDE_Type
		,@pvchTBLE_TableFAP		,@pvchTBLE_CodeFAP	,@pvchTBLE_TableFAS		,@pvchTBLE_CodeFAS
		,@pintPROD_Code			,@pintSERV_Code		,@pvchTBLE_TableUNM		,@pvchTBLE_CodeUNM
		,@pvchTBLE_TableTAI		,@pvchTBLE_CodeTAI	,@pdecPLDE_UnitValue	,@pdecPLDE_UnitPrice
		,@pdecPLDE_Quantity		,@pdecPLDE_IGV		,@pdecPLDE_ISC			,@pdecPROF_Discount
		,@pvchAUDI_CreationUser	,GETDATE()			)

END
GO


IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PFDEU_AProformaDetail]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[PFDEU_AProformaDetail]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[PFDEU_AProformaDetail]
( 
	 @pintBUSI_Code				INT OUTPUT
	,@pintPROF_Code				INT OUTPUT
	,@pintPFDE_Item				INT OUTPUT
	,@pchrPFDE_Type				CHAR(1)
	,@pvchTBLE_TableFAP			VARCHAR(3)
	,@pvchTBLE_CodeFAP			VARCHAR(6)
	,@pvchTBLE_TableFAS			VARCHAR(3)
	,@pvchTBLE_CodeFAS			VARCHAR(6)
	,@pintPROD_Code				INT 
	,@pintSERV_Code				INT 
	,@pvchTBLE_TableUNM			VARCHAR(3) 
	,@pvchTBLE_CodeUNM			VARCHAR(6) 
	,@pvchTBLE_TableTAI			VARCHAR(3) 
	,@pvchTBLE_CodeTAI			VARCHAR(6) 
	,@pdecPLDE_UnitValue		DECIMAL(20, 8)
	,@pdecPLDE_UnitPrice		DECIMAL(20, 8)
	,@pdecPLDE_Quantity			DECIMAL(20, 8)
	,@pdecPLDE_IGV				DECIMAL(20, 8)
	,@pdecPLDE_ISC				DECIMAL(20, 8)
	,@pdecPROF_Discount			DECIMAL(20, 8)
	,@pvchAUDI_ModificationUser	VARCHAR(20) 

) 
AS 
BEGIN

	UPDATE [VENPY_ProformaDetails]
	SET  [PFDE_Type]				= @pchrPFDE_Type
		,[TBLE_TableFAP]			= @pvchTBLE_TableFAP
		,[TBLE_CodeFAP]				= @pvchTBLE_CodeFAP
		,[TBLE_TableFAS]			= @pvchTBLE_TableFAS
		,[TBLE_CodeFAS]				= @pvchTBLE_CodeFAS
		,[PROD_Code]				= @pintPROD_Code
		,[SERV_Code]				= @pintSERV_Code
		,[TBLE_TableUNM]			= @pvchTBLE_TableUNM
		,[TBLE_CodeUNM]				= @pvchTBLE_CodeUNM
		,[TBLE_TableTAI]			= @pvchTBLE_TableTAI
		,[TBLE_CodeTAI]				= @pvchTBLE_CodeTAI
		,[PLDE_UnitValue]			= @pdecPLDE_UnitValue
		,[PLDE_UnitPrice]			= @pdecPLDE_UnitPrice
		,[PLDE_Quantity]			= @pdecPLDE_Quantity
		,[PLDE_IGV]					= @pdecPLDE_IGV
		,[PLDE_ISC]					= @pdecPLDE_ISC
		,[PROF_Discount]			= @pdecPROF_Discount
		,[AUDI_ModificationUser]	= @pvchAUDI_ModificationUser
		,[AUDI_ModificationDate]	= GETDATE()
	WHERE 
	[BUSI_Code] = @pintBUSI_Code AND 
	[PROF_Code] = @pintPROF_Code AND 
	[PFDE_Item] = @pintPFDE_Item

END
GO


IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PFDED_AProformaDetail]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[PFDED_AProformaDetail]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[PFDED_AProformaDetail]
( 
	 @pintBUSI_Code		INT
	,@pintPROF_Code		INT
	,@pintPFDE_Item		INT

) 
AS 
BEGIN

	DELETE FROM [VENPY_ProformaDetails]
	WHERE 
	[BUSI_Code] = @pintBUSI_Code AND 
	[PROF_Code] = @pintPROF_Code AND 
	[PFDE_Item] = @pintPFDE_Item

END
GO
