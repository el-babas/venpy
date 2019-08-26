IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PRLIS_ListPriceList]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[PRLIS_ListPriceList]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[PRLIS_ListPriceList]
(	 
	 @pintBUSI_Code		INT 
	,@pvchPRLI_Name		VARCHAR(50) 
) 
AS
BEGIN
	
	SELECT 
	 PRLI.BUSI_Code		,PRLI.PRLI_Code		,PRLI.PRLI_Active	,PRLI.TBLE_TableMND
	,PRLI.TBLE_CodeMND	,PRLI.PRLI_Name		,PRLI.PRLI_Description 
	,TMND.TBLE_Description1 AS TBLE_NameMND
	FROM [dbo].[VENPY_PriceList] AS PRLI
	INNER JOIN [dbo].[VENPY_Tables] AS TMND ON TMND.BUSI_Code = PRLI.BUSI_Code AND TMND.TBLE_Table = PRLI.TBLE_TableMND AND TMND.TBLE_Code = PRLI.TBLE_CodeMND
	WHERE 
	PRLI.BUSI_Code = @pintBUSI_Code AND	
	PRLI.PRLI_Name LIKE '%' + ISNULL(@pvchPRLI_Name,'') +'%'		

END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PRLIS_ByUser]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[PRLIS_ByUser]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[PRLIS_ByUser]
(	 
	 @pintBUSI_Code		INT 
	,@pintUSER_Code		INT
) 
AS
BEGIN
	
	DECLARE @pvchPCON_Value VARCHAR(50) 
	SET @pvchPCON_Value = (SELECT PCON_Value FROM dbo.VENPY_PersonalConfiguration WHERE BUSI_Code = @pintBUSI_Code AND USER_Code = @pintUSER_Code AND PCON_Key = 'PLPR')

	SELECT 
	 PRLI.BUSI_Code		,PRLI.PRLI_Code		,PRLI.PRLI_Active	,PRLI.TBLE_TableMND
	,PRLI.TBLE_CodeMND	,PRLI.PRLI_Name		,PRLI.PRLI_Description 
	FROM [dbo].[VENPY_PriceList] AS PRLI
	WHERE 
	PRLI.BUSI_Code = @pintBUSI_Code AND	
	PRLI.PRLI_Active = 1  AND 
	PRLI.PRLI_Code IN (SELECT Item FROM dbo.SplitString(@pvchPCON_Value,'|'))
	

END
GO


IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PRLIS_APriceList]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[PRLIS_APriceList]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[PRLIS_APriceList]
( 
	 @pintBUSI_Code		INT 
	,@pintPRLI_Code		INT 
) 
AS
BEGIN

	SELECT 
	 PRLI.BUSI_Code			,PRLI.PRLI_Code		,PRLI.PRLI_Active	,PRLI.TBLE_TableMND
	,PRLI.TBLE_CodeMND		,PRLI.PRLI_Name		,PRLI.TBLE_TableTAI	,PRLI.TBLE_CodeTAI
	,PRLI.PRLI_Description 
	FROM [dbo].[VENPY_PriceList] AS PRLI
	WHERE 
	PRLI.BUSI_Code= @pintBUSI_Code AND 
	PRLI.PRLI_Code= @pintPRLI_Code

END
GO


IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PRLII_APriceList]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[PRLII_APriceList]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[PRLII_APriceList]
( 
	 @pintBUSI_Code			INT
	,@pintPRLI_Code			INT OUTPUT
	,@pbitPRLI_Active		BIT 
	,@pvchTBLE_TableMND		VARCHAR(3) 
	,@pvchTBLE_CodeMND		VARCHAR(6) 
	,@pvchPRLI_Name			VARCHAR(50)
	,@pvchTBLE_TableTAI		VARCHAR(3) 
	,@pvchTBLE_CodeTAI		VARCHAR(6) 
	,@pvchPRLI_Description	VARCHAR(100) 
	,@pvchAUDI_CreationUser	VARCHAR(20)
) 
AS 
BEGIN
	
	SET @pintPRLI_Code = ISNULL((SELECT MAX(PRLI_Code) FROM [VENPY_PriceList] WHERE BUSI_Code = @pintBUSI_Code ) + 1,1)
	INSERT INTO [VENPY_PriceList]
		( BUSI_Code			, PRLI_Code			, PRLI_Active		, TBLE_TableMND
	    , TBLE_CodeMND		, PRLI_Name			, TBLE_TableTAI		, TBLE_CodeTAI
	    , PRLI_Description	, AUDI_CreationUser , AUDI_CreationDate )
	VALUES
		( @pintBUSI_Code		, @pintPRLI_Code			, @pbitPRLI_Active		, @pvchTBLE_TableMND
		, @pvchTBLE_CodeMND		, @pvchPRLI_Name			, @pvchTBLE_TableTAI	, @pvchTBLE_CodeTAI
		, @pvchPRLI_Description , @pvchAUDI_CreationUser	, GETDATE())

END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PRLIU_APriceList]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[PRLIU_APriceList]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[PRLIU_APriceList]
( 
	 @pintBUSI_Code					INT
	,@pintPRLI_Code					INT OUTPUT 
	,@pbitPRLI_Active				BIT 
	,@pvchTBLE_TableMND				VARCHAR(3) 
	,@pvchTBLE_CodeMND				VARCHAR(6) 
	,@pvchPRLI_Name					VARCHAR(50)
	,@pvchTBLE_TableTAI				VARCHAR(3) 
	,@pvchTBLE_CodeTAI				VARCHAR(6) 
	,@pvchPRLI_Description			VARCHAR(100) 
	,@pvchAUDI_ModificationUser		VARCHAR(20)

) AS 
BEGIN

	UPDATE [VENPY_PriceList]
		SET [PRLI_Active]			= @pbitPRLI_Active
	      , [TBLE_TableMND]			= @pvchTBLE_TableMND
	      , [TBLE_CodeMND]			= @pvchTBLE_CodeMND
	      , [PRLI_Name]				= @pvchPRLI_Name
	      , [TBLE_TableTAI]			= @pvchTBLE_TableTAI
	      , [TBLE_CodeTAI]			= @pvchTBLE_CodeTAI
	      , [PRLI_Description]		= @pvchPRLI_Description
	      , [AUDI_ModificationUser] = @pvchAUDI_ModificationUser
	      , [AUDI_ModificationDate] = GETDATE()
	WHERE 
	[BUSI_Code] = @pintBUSI_Code AND 
	[PRLI_Code] = @pintPRLI_Code

END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PRLID_APriceList]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[PRLID_APriceList]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[PRLID_APriceList]
( 
	 @pintBUSI_Code		INT 
	,@pintPRLI_Code		INT 
) 
AS
BEGIN

	DELETE FROM [dbo].[VENPY_PriceListDetail]
	WHERE 
	[BUSI_Code] = @pintBUSI_Code AND 
	[PRLI_Code] = @pintPRLI_Code

	DELETE FROM [dbo].[VENPY_PriceList]
	WHERE 
	[BUSI_Code] = @pintBUSI_Code AND 
	[PRLI_Code] = @pintPRLI_Code

END
GO