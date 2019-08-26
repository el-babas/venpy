IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBLES_All]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[TBLES_All]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[TBLES_All]
(
	 @pintBUSI_Code		INT 
)
AS
BEGIN 
	SELECT 
		 TBLE.BUSI_Code			,TBLE.TBLE_Table		,TBLE.TBLE_Code			,TBLE.TBLE_InternationalCode	
		,TBLE.TBLE_SunatCode	,TBLE.TBLE_Description1	,TBLE.TBLE_Description2	,TBLE.TBLE_Number1		
		,TBLE.TBLE_Number2		,TBLE.TBLE_Status		,TBLE.TBLE_Default 
	FROM dbo.VENPY_Tables AS TBLE
	WHERE 
		TBLE.BUSI_Code = @pintBUSI_Code AND 
		TBLE.TBLE_Status = 'A' 
	ORDER BY 
		TBLE.BUSI_Code , TBLE.TBLE_Table , TBLE.TBLE_Description1
END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBLES_ListTables]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[TBLES_ListTables]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[TBLES_ListTables]
(
	 @pintBUSI_Code		INT 
	,@pvchTBLE_Table	VARCHAR(3)
)
AS
BEGIN 
	SELECT 
		 TBLE.BUSI_Code			,TBLE.TBLE_Table		,TBLE.TBLE_Code			,TBLE.TBLE_Description1		
		,TBLE.TBLE_Status		,TBLE.TBLE_Default
		,CASE TBLE.TBLE_Status	WHEN 'A' THEN 'ACTIVO'
								WHEN 'I' THEN 'INACTIVO'
		 END AS TBLE_NameStatus
	FROM dbo.VENPY_Tables AS TBLE
	WHERE 
		TBLE.BUSI_Code = @pintBUSI_Code 
	AND TBLE.TBLE_Table = @pvchTBLE_Table
	ORDER BY 
		TBLE.BUSI_Code , TBLE.TBLE_Table , TBLE.TBLE_Code
END
GO


IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBLES_ATable]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[TBLES_ATable]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[TBLES_ATable]
(
	 @pintBUSI_Code		INT 
	,@pvchTBLE_Table	VARCHAR(3)
	,@pvchTBLE_Code		VARCHAR(6)
)
AS
BEGIN 
	SELECT 
		 TBLE.BUSI_Code			,TBLE.TBLE_Table		,TBLE.TBLE_Code			,TBLE.TBLE_InternationalCode	
		,TBLE.TBLE_SunatCode	,TBLE.TBLE_Description1	,TBLE.TBLE_Description2	,TBLE.TBLE_Number1		
		,TBLE.TBLE_Number2		,TBLE.TBLE_Status		,TBLE.TBLE_Default 
	FROM dbo.VENPY_Tables AS TBLE
	WHERE 
		TBLE.BUSI_Code = @pintBUSI_Code AND 
		TBLE.TBLE_Table = @pvchTBLE_Table AND 
		TBLE.TBLE_Code = @pvchTBLE_Code
END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBLEI_ATable]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[TBLEI_ATable]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[TBLEI_ATable]
( 
	 @pintBUSI_Code					INT 
	,@pvchTBLE_Table				VARCHAR(3) OUTPUT
	,@pvchTBLE_Code					VARCHAR(6) OUTPUT
	,@pvchTBLE_InternationalCode	VARCHAR(5) 
	,@pvchTBLE_SunatCode			VARCHAR(20) 
	,@pvchTBLE_Description1			VARCHAR(200) 
	,@pvchTBLE_Description2			VARCHAR(150) 
	,@pintTBLE_Number1				INT 
	,@pdecTBLE_Number2				DECIMAL(12, 2)
	,@pchrTBLE_Status				CHAR(1)
	,@pbitTBLE_Default				BIT
	,@pvchAUDI_CreationUser			VARCHAR(20)
) 
AS 
BEGIN

	SET @pvchTBLE_Code =  RIGHT('000' + CONVERT(VARCHAR(6),ISNULL(TRY_PARSE((SELECT MAX(TBLE_Code) FROM [dbo].[VENPY_Tables] WHERE BUSI_Code = @pintBUSI_Code AND TBLE_Table = @pvchTBLE_Table) AS INT) + 1,1)) , 3)
	INSERT INTO [VENPY_Tables]
		(BUSI_Code		,TBLE_Table			,TBLE_Code			,TBLE_InternationalCode
		,TBLE_SunatCode	,TBLE_Description1	,TBLE_Description2	,TBLE_Number1
		,TBLE_Number2	,TBLE_Status		,TBLE_Default		,AUDI_CreationUser
		,AUDI_CreationDate)   
	VALUES
		(@pintBUSI_Code			,@pvchTBLE_Table			,@pvchTBLE_Code			,@pvchTBLE_InternationalCode
		,@pvchTBLE_SunatCode	,@pvchTBLE_Description1		,@pvchTBLE_Description2	,@pintTBLE_Number1
		,@pdecTBLE_Number2		,@pchrTBLE_Status			,@pbitTBLE_Default		,@pvchAUDI_CreationUser
		,GETDATE())

END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBLEU_ATable]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[TBLEU_ATable]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[TBLEU_ATable]
( 
	 @pintBUSI_Code					INT 
	,@pvchTBLE_Table				VARCHAR(3)
	,@pvchTBLE_Code					VARCHAR(6)
	,@pvchTBLE_InternationalCode	VARCHAR(5) 
	,@pvchTBLE_SunatCode			VARCHAR(20) 
	,@pvchTBLE_Description1			VARCHAR(200) 
	,@pvchTBLE_Description2			VARCHAR(150) 
	,@pintTBLE_Number1				INT 
	,@pdecTBLE_Number2				DECIMAL(12, 2)
	,@pchrTBLE_Status				CHAR(1)
	,@pbitTBLE_Default				BIT
	,@pvchAUDI_ModificationUser		VARCHAR(20) = NULL
)
AS 
BEGIN

	UPDATE [VENPY_Tables]
	   SET [TBLE_InternationalCode] = @pvchTBLE_InternationalCode
	     , [TBLE_SunatCode] = @pvchTBLE_SunatCode
	     , [TBLE_Description1] = @pvchTBLE_Description1
	     , [TBLE_Description2] = @pvchTBLE_Description2
	     , [TBLE_Number1] = @pintTBLE_Number1
	     , [TBLE_Number2] = @pdecTBLE_Number2
	     , [TBLE_Status] = @pchrTBLE_Status
	     , [TBLE_Default] = @pbitTBLE_Default
	     , [AUDI_ModificationUser] = @pvchAUDI_ModificationUser
	     , [AUDI_ModificationDate] = GETDATE()
	 WHERE [BUSI_Code] = @pintBUSI_Code
	   AND [TBLE_Table] = @pvchTBLE_Table
	   AND [TBLE_Code] = @pvchTBLE_Code
	
END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TBLED_ATable]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[TBLED_ATable]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[TBLED_ATable]
( 
	 @pintBUSI_Code					INT 
	,@pvchTBLE_Table				VARCHAR(3)
	,@pvchTBLE_Code					VARCHAR(6)
) 
AS 
BEGIN

	DELETE FROM [VENPY_Tables]
	WHERE 
		[BUSI_Code] = @pintBUSI_Code AND 
		[TBLE_Table] = @pvchTBLE_Table AND 
		[TBLE_Code] = @pvchTBLE_Code

END
GO