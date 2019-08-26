IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EXRAI_AExchangeRate]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[EXRAI_AExchangeRate]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[EXRAI_AExchangeRate]
( 
	 @pintBUSI_Code					INT 
	,@pdteEXRA_Date					DATE  OUTPUT
	,@pdecEXRA_OfficialPurchase		DECIMAL(10, 3)
	,@pdecEXRA_OfficialSale			DECIMAL(10, 3)
	,@pdecEXRA_InternalPurchase		DECIMAL(10, 3)
	,@pdecEXRA_InternalSale			DECIMAL(10, 3)
	,@pvchAUDI_CreationUser			VARCHAR(20)
) 
AS 
BEGIN

	INSERT INTO [VENPY_ExchangeRate]
	( BUSI_Code				, EXRA_Date			, EXRA_OfficialPurchase	, EXRA_OfficialSale
	, EXRA_InternalPurchase , EXRA_InternalSale	, AUDI_CreationUser		, AUDI_CreationDate )
	VALUES
	( @pintBUSI_Code				, @pdteEXRA_Date			, @pdecEXRA_OfficialPurchase	, @pdecEXRA_OfficialSale
	, @pdecEXRA_InternalPurchase	, @pdecEXRA_InternalSale	, @pvchAUDI_CreationUser		, GETDATE() )

END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EXRAU_AExchangeRate]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[EXRAU_AExchangeRate]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[EXRAU_AExchangeRate]
( 
	 @pintBUSI_Code					INT 
	,@pdteEXRA_Date					DATE  OUTPUT
	,@pdecEXRA_OfficialPurchase		DECIMAL(10, 3)
	,@pdecEXRA_OfficialSale			DECIMAL(10, 3)
	,@pdecEXRA_InternalPurchase		DECIMAL(10, 3)
	,@pdecEXRA_InternalSale			DECIMAL(10, 3)
	,@pvchAUDI_ModificationUser		VARCHAR(20)
) 
AS 
BEGIN

	UPDATE [VENPY_ExchangeRate]
		SET	 [EXRA_OfficialPurchase]	= @pdecEXRA_OfficialPurchase
			,[EXRA_OfficialSale]		= @pdecEXRA_OfficialSale
			,[EXRA_InternalPurchase]	= @pdecEXRA_InternalPurchase
			,[EXRA_InternalSale]		= @pdecEXRA_InternalSale
			,[AUDI_ModificationUser]	= @pvchAUDI_ModificationUser
			,[AUDI_ModificationDate]	= GETDATE()
	WHERE 
	[BUSI_Code] = @pintBUSI_Code AND 
	[EXRA_Date] = @pdteEXRA_Date

END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EXRAS_ListExchangeRate]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[EXRAS_ListExchangeRate]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[EXRAS_ListExchangeRate]
(
	 @pintBUSI_Code		INT 
	,@pchrEXRA_Year		CHAR(4)
	,@pchrEXRA_Month	CHAR(2)
)
AS
BEGIN 
	
	SELECT BUSI_Code			, EXRA_Date				, EXRA_OfficialPurchase 
		 , EXRA_OfficialSale	, EXRA_InternalPurchase	, EXRA_InternalSale 
	FROM [dbo].[VENPY_ExchangeRate]
	WHERE 
	BUSI_Code = @pintBUSI_Code AND 
	YEAR(EXRA_Date) = @pchrEXRA_Year AND 
	MONTH(EXRA_Date) = @pchrEXRA_Month

END 
GO 

