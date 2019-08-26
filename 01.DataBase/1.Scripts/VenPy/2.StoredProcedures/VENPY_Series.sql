IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SERII_ASerie]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[SERII_ASerie]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[SERII_ASerie]
( 
	 @pintBUSI_Code				INT 
	,@pintSERI_Code				INT 
	,@pvchTBLE_TableTDO			VARCHAR(3)
	,@pvchTBLE_CodeTDO			VARCHAR(6) 
	,@pchrSERI_Serie			CHAR(4)
	,@pintSERI_Number			INT
	,@pvchSERI_Description		VARCHAR(100)
	,@pvchAUDI_CreationUser		VARCHAR(20)
) 
AS 
BEGIN

	SET @pintSERI_Code = ISNULL((SELECT MAX(SERI_Code) FROM [VENPY_Series] WHERE BUSI_Code = @pintBUSI_Code ) + 1,1)
	INSERT INTO [VENPY_Series]
		( BUSI_Code			, SERI_Code		, TBLE_TableTDO		, TBLE_CodeTDO
		, SERI_Serie		, SERI_Number	, SERI_Description	, AUDI_CreationUser
		, AUDI_CreationDate )
	VALUES
		( @pintBUSI_Code		, @pintSERI_Code	, @pvchTBLE_TableTDO	, @pvchTBLE_CodeTDO
		, UPPER(@pchrSERI_Serie), @pintSERI_Number	, @pvchSERI_Description	, @pvchAUDI_CreationUser
		, GETDATE() )

END
GO


IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SERIU_ASerie]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[SERIU_ASerie]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[SERIU_ASerie]
( 
	 @pintBUSI_Code				INT 
	,@pintSERI_Code				INT 
	,@pvchTBLE_TableTDO			VARCHAR(3)
	,@pvchTBLE_CodeTDO			VARCHAR(6) 
	,@pchrSERI_Serie			CHAR(4)
	,@pintSERI_Number			INT
	,@pvchSERI_Description		VARCHAR(100)
	,@pvchAUDI_ModificationUser	VARCHAR(20)
)
AS 
BEGIN

	UPDATE [VENPY_Series]
	SET  [TBLE_TableTDO]			= @pvchTBLE_TableTDO
		,[TBLE_CodeTDO]				= @pvchTBLE_CodeTDO
		,[SERI_Serie]				= UPPER(@pchrSERI_Serie)
		,[SERI_Number]				= @pintSERI_Number
		,[SERI_Description]			= @pvchSERI_Description
		,[AUDI_ModificationUser]	= @pvchAUDI_ModificationUser
		,[AUDI_ModificationDate]	= GETDATE()
	WHERE 
	[BUSI_Code] = @pintBUSI_Code AND 
	[SERI_Code] = @pintSERI_Code

END
GO


IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SERID_ASerie]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[SERID_ASerie]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[SERID_ASerie]
( 
	 @pintBUSI_Code		INT 
	,@pintSERI_Code		INT 
)
AS 
BEGIN

   DELETE FROM [VENPY_Series]
    WHERE [BUSI_Code] = @pintBUSI_Code
      AND [SERI_Code] = @pintSERI_Code

END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SERIS_ListSeries]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[SERIS_ListSeries]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[SERIS_ListSeries]
( 
	 @pintBUSI_Code			INT
	,@pvchTBLE_TableTDO		VARCHAR(3)
	,@pvchTBLE_CodeTDO		VARCHAR(6) 
) 
AS
BEGIN

	SELECT	 BUSI_Code	, SERI_Code		, TBLE_TableTDO		, TBLE_CodeTDO
			,SERI_Serie	, SERI_Number	, SERI_Description 
	FROM VENPY_Series
	WHERE 
	BUSI_Code= BUSI_Code AND 
	TBLE_TableTDO = @pvchTBLE_TableTDO AND
    TBLE_CodeTDO = @pvchTBLE_CodeTDO

END
GO