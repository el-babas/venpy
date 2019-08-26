IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[WABRS_ByBranch]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[WABRS_ByBranch]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[WABRS_ByBranch]
(	 
	 @pintBUSI_Code		INT 
	,@pintBOFF_Code		INT 
) 
AS
BEGIN
	
	SELECT BUSI_Code  AS BUSI_Code ,
           TBLE_Table AS TBLE_TableALM ,
           TBLE_Code  AS TBLE_CodeALM ,
           TBLE_Description1 AS TBLE_NameALM ,
		   CONVERT(BIT,0) AS WABR_Select 
	INTO #TMP_Warehouses
	FROM dbo.VENPY_Tables AS TALM
	WHERE 
	TALM.BUSI_Code = @pintBUSI_Code AND 
	TALM.TBLE_Table = 'ALM' AND 
	TALM.TBLE_Status = 'A'

	UPDATE TALM
		SET TALM.WABR_Select = CONVERT(BIT,1)
	FROM #TMP_Warehouses AS TALM
	INNER JOIN dbo.VENPY_WarehousesBranches AS WABR ON	WABR.BUSI_Code = TALM.BUSI_Code AND 
														WABR.TBLE_CodeALM = TALM.TBLE_CodeALM AND 
														WABR.TBLE_TableALM = TALM.TBLE_TableALM	AND 
														WABR.BOFF_Code = @pintBOFF_Code

	SELECT * FROM #TMP_Warehouses 

END
GO 

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[WABRI_ByBranch]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[WABRI_ByBranch]
GO

IF EXISTS (SELECT * FROM sys.types WHERE user_type_id =  TYPE_ID('[dbo].[UDTT_WarehousesBranches]'))
	DROP TYPE [dbo].[UDTT_WarehousesBranches]
GO 

CREATE TYPE [dbo].[UDTT_WarehousesBranches] AS TABLE(
	BUSI_Code		INT			NOT NULL,
	BOFF_Code		INT			NOT NULL,
	TBLE_TableALM	VARCHAR(3)	NOT NULL,
	TBLE_CodeALM	VARCHAR(6)	NOT NULL
)
GO 

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[WABRI_ByBranch]
(	 
	 @pintBUSI_Code					INT 
	,@pintBOFF_Code					INT
	,@ptabUDTT_WarehousesBranches	UDTT_WarehousesBranches READONLY
	,@pvchAUDI_CreationUser			VARCHAR(20)  
) 
AS
BEGIN

	DELETE FROM dbo.VENPY_WarehousesBranches WHERE BUSI_Code = @pintBUSI_Code AND BOFF_Code = @pintBOFF_Code
	SELECT * INTO #TMP_WarehousesBranches FROM @ptabUDTT_WarehousesBranches

	INSERT INTO dbo.VENPY_WarehousesBranches
	        ( BUSI_Code		,BOFF_Code	,TBLE_TableALM	,TBLE_CodeALM	,AUDI_CreationUser	,AUDI_CreationDate )
	SELECT WABR.BUSI_Code ,
           @pintBOFF_Code ,
           WABR.TBLE_TableALM ,
           WABR.TBLE_CodeALM ,
		   @pvchAUDI_CreationUser ,
		   GETDATE()
	FROM #TMP_WarehousesBranches AS WABR

END 
GO 