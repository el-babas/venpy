IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PROFS_ListProformas]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[PROFS_ListProformas]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[PROFS_ListProformas]
( 
	 @pintBUSI_Code			INT
	,@pvchPROF_Number		VARCHAR(50)
	,@pdtePROF_DateBegin	DATE
	,@pdtePROF_DateEnd		DATE
	,@pbitPROF_OnlyActive	BIT
) 
AS 
BEGIN

	SELECT	 PROF.BUSI_Code		,PROF.PROF_Code		,PROF.ENTI_Code		,PROF.PROF_Number		,PROF.PROF_Date
			,PROF.TBLE_TableMND	,PROF.TBLE_CodeMND	,PROF.PROF_Status	,PROF.PROF_TotalPrice
			,TMND.TBLE_Description1 AS TBLE_NameMND 
			,ENTI.ENTI_BusinessName AS PROF_CustomerName
			,CASE PROF.PROF_Status	WHEN 'A' THEN 'ACTIVO'
									WHEN 'X' THEN 'ANULADO'
									ELSE 'SIN ESTADO' END AS PROF_NameStatus 
	FROM VENPY_Proformas AS PROF
	LEFT JOIN dbo.VENPY_Entities AS ENTI ON ENTI.BUSI_Code = PROF.BUSI_Code AND ENTI.ENTI_Code = PROF.ENTI_Code
	LEFT JOIN dbo.VENPY_Tables AS TMND ON TMND.BUSI_Code = PROF.BUSI_Code AND TMND.TBLE_Table = PROF.TBLE_TableMND AND TMND.TBLE_Code = PROF.TBLE_CodeMND
	WHERE 
	PROF.BUSI_Code = @pintBUSI_Code AND 
	PROF.PROF_Number = @pvchPROF_Number AND
    PROF.PROF_Date BETWEEN @pdtePROF_DateBegin AND @pdtePROF_DateEnd AND 
	PROF.PROF_Status = CASE ISNULL(@pbitPROF_OnlyActive,0) WHEN 1 THEN 'A' ELSE PROF.PROF_Status END 
	ORDER BY PROF.PROF_Date , CONVERT(INT,PROF_Number)
END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PROFS_AProforma]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[PROFS_AProforma]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[PROFS_AProforma]
( 
	 @pintBUSI_Code		INT
	,@pintPROF_Code		INT 
) 
AS
BEGIN

	SELECT	 PROF.BUSI_Code				,PROF.PROF_Code		,PROF.ENTI_Code			,PROF.PROF_Number
			,PROF.PROF_Date				,PROF.PROF_DueDate	,PROF.TBLE_TableMND		,PROF.TBLE_CodeMND
			,PROF.PRLI_Code				,PROF.PROF_Status	,PROF.PROF_Export		,PROF.PROF_IGV
			,PROF.PROF_PercentageIGV	,PROF.PROF_ISC		,PROF.PROF_Discount		,PROF.PROF_TotalPrice
			,PROF.PROF_Generated 
	FROM VENPY_Proformas AS PROF
	WHERE 
	BUSI_Code = @pintBUSI_Code AND 
	PROF_Code = @pintPROF_Code

END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PROFI_AProforma]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[PROFI_AProforma]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[PROFI_AProforma]
( 
	 @pintBUSI_Code				INT 
	,@pintPROF_Code				INT OUTPUT
	,@pintENTI_Code				INT 
	,@pvchPROF_Number			VARCHAR(50) 
	,@pdtePROF_Date				DATE 
	,@pdtePROF_DueDate			DATE
	,@pvchTBLE_TableMND			VARCHAR(3)
	,@pvchTBLE_CodeMND			VARCHAR(6) 
	,@pintPRLI_Code				INT 
	,@pchrPROF_Status			CHAR(1) 
	,@pbitPROF_Export			BIT 
	,@pdecPROF_IGV				DECIMAL(20, 8) 
	,@pdecPROF_PercentageIGV	DECIMAL(20, 3)
	,@pdecPROF_ISC				DECIMAL(20, 8) 
	,@pdecPROF_Discount			DECIMAL(20, 8) 
	,@pdecPROF_TotalPrice		DECIMAL(20, 8)
	,@pbitPROF_Generated		BIT 
	,@pvchAUDI_CreationUser		VARCHAR(20)
) 
AS 
BEGIN

	SET @pintPROF_Code = ISNULL((SELECT MAX(PROF_Code) FROM [dbo].[VENPY_Proformas] WHERE BUSI_Code = @pintBUSI_Code ) + 1,1)
	INSERT INTO [VENPY_Proformas]
	(BUSI_Code			,PROF_Code			,ENTI_Code			,PROF_Number
	,PROF_Date			,PROF_DueDate		,TBLE_TableMND		,TBLE_CodeMND
	,PRLI_Code			,PROF_Status		,PROF_Export		,PROF_IGV
	,PROF_PercentageIGV ,PROF_ISC			,PROF_Discount		,PROF_TotalPrice
	,PROF_Generated		,AUDI_CreationUser	,AUDI_CreationDate	) 
	VALUES
	(@pintBUSI_Code				,@pintPROF_Code				,@pintENTI_Code			,@pvchPROF_Number
	,@pdtePROF_Date				,@pdtePROF_DueDate			,@pvchTBLE_TableMND		,@pvchTBLE_CodeMND
	,@pintPRLI_Code				,@pchrPROF_Status			,@pbitPROF_Export		,@pdecPROF_IGV
	,@pdecPROF_PercentageIGV	,@pdecPROF_ISC				,@pdecPROF_Discount		,@pdecPROF_TotalPrice
	,@pbitPROF_Generated		,@pvchAUDI_CreationUser		,GETDATE() )

END
GO


IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PROFU_AProforma]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[PROFU_AProforma]

GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[PROFU_AProforma]
( 
	 @pintBUSI_Code				INT 
	,@pintPROF_Code				INT OUTPUT
	,@pintENTI_Code				INT 
	,@pvchPROF_Number			VARCHAR(50) 
	,@pdtePROF_Date				DATE 
	,@pdtePROF_DueDate			DATE
	,@pvchTBLE_TableMND			VARCHAR(3)
	,@pvchTBLE_CodeMND			VARCHAR(6) 
	,@pintPRLI_Code				INT 
	,@pchrPROF_Status			CHAR(1) 
	,@pbitPROF_Export			BIT 
	,@pdecPROF_IGV				DECIMAL(20, 8) 
	,@pdecPROF_PercentageIGV	DECIMAL(20, 3)
	,@pdecPROF_ISC				DECIMAL(20, 8) 
	,@pdecPROF_Discount			DECIMAL(20, 8) 
	,@pdecPROF_TotalPrice		DECIMAL(20, 8)
	,@pbitPROF_Generated		BIT 
	,@pvchAUDI_ModificationUser VARCHAR(20) 

) 
AS 
BEGIN

	UPDATE [VENPY_Proformas]
		SET  [ENTI_Code]				= @pintENTI_Code
			,[PROF_Number]				= @pvchPROF_Number
			,[PROF_Date]				= @pdtePROF_Date
			,[PROF_DueDate]				= @pdtePROF_DueDate
			,[TBLE_TableMND]			= @pvchTBLE_TableMND
			,[TBLE_CodeMND]				= @pvchTBLE_CodeMND
			,[PRLI_Code]				= @pintPRLI_Code
			,[PROF_Status]				= @pchrPROF_Status
			,[PROF_Export]				= @pbitPROF_Export
			,[PROF_IGV]					= @pdecPROF_IGV
			,[PROF_PercentageIGV]		= @pdecPROF_PercentageIGV
			,[PROF_ISC]					= @pdecPROF_ISC
			,[PROF_Discount]			= @pdecPROF_Discount
			,[PROF_TotalPrice]			= @pdecPROF_TotalPrice
			,[PROF_Generated]			= @pbitPROF_Generated
			,[AUDI_ModificationUser]	= @pvchAUDI_ModificationUser
			,[AUDI_ModificationDate]	= GETDATE()
	WHERE 
	[BUSI_Code] = @pintBUSI_Code AND 
	[PROF_Code] = @pintPROF_Code
	
END
GO