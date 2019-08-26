IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MUPRS_ByProduct]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[MUPRS_ByProduct]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[MUPRS_ByProduct]
(	 
	 @pintBUSI_Code				INT 
	,@pintPROD_Code				INT 
) 
AS
BEGIN
	
	SELECT BUSI_Code ,
           PROD_Code ,
           TBLE_TableUNM ,
           TBLE_CodeUNM ,
           MUPR_ConversionFactor 
	FROM [dbo].[VENPY_MeasurementUnitsProducts] AS MUPR
	WHERE 
	MUPR.BUSI_Code = @pintBUSI_Code AND 
	MUPR.PROD_Code = @pintPROD_Code
	ORDER BY MUPR_ConversionFactor 

END
GO 

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MUPRI_ByProduct]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[MUPRI_ByProduct]
GO

IF EXISTS (SELECT * FROM sys.types WHERE user_type_id =  TYPE_ID('[dbo].[UDTT_MeasurementUnitsProducts]'))
	DROP TYPE [dbo].[UDTT_MeasurementUnitsProducts]
GO 

CREATE TYPE [dbo].[UDTT_MeasurementUnitsProducts] AS TABLE(
	BUSI_Code				INT				NOT NULL,
	PROD_Code				INT				NOT NULL,
	TBLE_TableUNM			VARCHAR(3)		NOT NULL,
	TBLE_CodeUNM			VARCHAR(6)		NOT NULL,
	MUPR_ConversionFactor	DECIMAL(12,5)	NOT NULL
)
GO 

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[MUPRI_ByProduct]
(	 
	 @pintBUSI_Code						INT 
	,@pintPROD_Code						INT
	,@ptabUDTT_MeasurementUnitsProducts	UDTT_MeasurementUnitsProducts READONLY
	,@pvchAUDI_CreationUser				VARCHAR(20)  
) 
AS
BEGIN

	DELETE FROM [dbo].[VENPY_MeasurementUnitsProducts] WHERE BUSI_Code = @pintBUSI_Code AND PROD_Code = @pintPROD_Code
	SELECT * INTO #TMP_MeasurementUnitsProducts FROM @ptabUDTT_MeasurementUnitsProducts

	INSERT INTO dbo.VENPY_MeasurementUnitsProducts
	( BUSI_Code				, PROD_Code			, TBLE_TableUNM		, TBLE_CodeUNM 
	, MUPR_ConversionFactor	, AUDI_CreationUser	, AUDI_CreationDate )
	SELECT 
	 BUSI_Code				,@pintPROD_Code			,TBLE_TableUNM	,TBLE_CodeUNM 
	,MUPR_ConversionFactor	,@pvchAUDI_CreationUser ,GETDATE()
	FROM #TMP_MeasurementUnitsProducts

END 
GO 