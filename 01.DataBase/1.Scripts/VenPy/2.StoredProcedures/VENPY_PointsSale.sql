IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PSALS_ByUser]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[PSALS_ByUser]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[PSALS_ByUser]
(	 
	 @pintUSER_Code		INT 
	,@pintBUSI_Code		INT
) 
AS
BEGIN
	
	SELECT	PSAL.BUSI_Code	, PSAL.BOFF_Code	, PSAL.PSAL_Code
		  , PSAL.PSAL_Name	, PSAL.PSAL_Main	, PSAL.PSAL_Status	
		  , BUSI.BUSI_RUC
	FROM dbo.VENPY_PointsSale AS PSAL
	INNER JOIN dbo.VENPY_Business AS BUSI ON BUSI.BUSI_Code = PSAL.BUSI_Code
	INNER JOIN dbo.VENPY_PointsSaleUsers AS UPSAL ON	UPSAL.BUSI_Code = PSAL.BUSI_Code AND 
														UPSAL.BOFF_Code = PSAL.BOFF_Code AND 
														UPSAL.PSAL_Code = PSAL.PSAL_Code
	WHERE 
	UPSAL.USER_Code = @pintUSER_Code AND	
	BUSI.BUSI_Code = ISNULL(@pintBUSI_Code,BUSI.BUSI_Code) AND 
	PSAL.PSAL_Status = 'A'
END
GO


IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PSALS_ListPointsSale]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[PSALS_ListPointsSale]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[PSALS_ListPointsSale]
(	 
	 @pintBUSI_Code		INT 
	,@pintUSER_Code		INT 
	,@pvchPSAL_Name		VARCHAR(100)
) 
AS
BEGIN

	SELECT	 PSAL.BUSI_Code		,PSAL.BOFF_Code		,PSAL.PSAL_Code 
			,PSAL.PSAL_Name		,PSAL.PSAL_Main		,PSAL.PSAL_Status 
			,CASE PSAL.PSAL_Status	WHEN 'A' THEN 'ACTIVO'
									WHEN 'I' THEN 'INACTIVO'
									WHEN 'C' THEN 'CERRADO' 
			 END AS PSAL_NameStatus
	FROM dbo.VENPY_PointsSale AS PSAL
	INNER JOIN dbo.VENPY_PointsSaleUsers AS UPSAL ON	UPSAL.BUSI_Code = PSAL.BUSI_Code AND 
														UPSAL.BOFF_Code = PSAL.BOFF_Code AND 
														UPSAL.PSAL_Code = PSAL.PSAL_Code
	WHERE 
	UPSAL.BUSI_Code = @pintBUSI_Code AND 
	UPSAL.USER_Code = @pintUSER_Code AND
	PSAL.PSAL_Name LIKE '%' + ISNULL(@pvchPSAL_Name,'') + '%' 

END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PSALS_APointSale]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[PSALS_APointSale]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[PSALS_APointSale]
(	 
	 @pintBUSI_Code INT
	,@pintBOFF_Code INT
	,@pintPSAL_Code INT
) 
AS
BEGIN

	SELECT	 PSAL.BUSI_Code		,PSAL.BOFF_Code		,PSAL.PSAL_Code 
			,PSAL.PSAL_Name		,PSAL.PSAL_Main		,PSAL.PSAL_Status 
	FROM dbo.VENPY_PointsSale AS PSAL
	WHERE 
	PSAL.BUSI_Code = @pintBUSI_Code AND 
	PSAL.BOFF_Code = @pintBOFF_Code AND 
	psal.PSAL_Code = @pintPSAL_Code

END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PSALI_APointSale]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[PSALI_APointSale]

GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[PSALI_APointSale]
( 
	 @pintBUSI_Code				INT 
	,@pintBOFF_Code				INT 
	,@pintPSAL_Code				INT 
	,@pvchPSAL_Name				VARCHAR(100) 
	,@pbitPSAL_Main				BIT
	,@pchrPSAL_Status			CHAR(1) 
	,@pvchAUDI_CreationUser		VARCHAR(20)
	,@pvchPSAL_ErrorMessage		VARCHAR(MAX) OUTPUT
) 
AS 
BEGIN
	IF (@pbitPSAL_Main = 0 OR NOT EXISTS(SELECT PSAL_Code FROM dbo.VENPY_PointsSale 
											WHERE BUSI_Code = @pintBUSI_Code AND BOFF_Code = @pintBOFF_Code AND PSAL_Main = 1))
	BEGIN 
		IF NOT EXISTS (SELECT PSAL_Code FROM [VENPY_PointsSale] 
						WHERE BUSI_Code = @pintBUSI_Code AND BOFF_Code = @pintBOFF_Code AND RTRIM(LTRIM(PSAL_Name)) = RTRIM(LTRIM(@pvchPSAL_Name)) )
		BEGIN
			SET @pintPSAL_Code = ISNULL((SELECT MAX(PSAL_Code) FROM [VENPY_PointsSale] WHERE BUSI_Code = @pintBUSI_Code AND BOFF_Code = @pintBOFF_Code) + 1,1)
			INSERT INTO [VENPY_PointsSale]
				(BUSI_Code	, BOFF_Code		, PSAL_Code			, PSAL_Name
				,PSAL_Main	, PSAL_Status	, AUDI_CreationUser	, AUDI_CreationDate)   
			VALUES
				(@pintBUSI_Code		, @pintBOFF_Code	, @pintPSAL_Code			, @pvchPSAL_Name
				,@pbitPSAL_Main		, @pchrPSAL_Status	, @pvchAUDI_CreationUser	, GETDATE() )
		END
		ELSE
		BEGIN 
			SET @pvchPSAL_ErrorMessage = 'Ya existe un Punto de Venta que pertenece a la misma Sucursal con el nombre ' + @pvchPSAL_Name
		END
	END 
	ELSE
	BEGIN 
		SET @pvchPSAL_ErrorMessage = 'Ya existe un Punto de Venta principal para la misma Sucursal '
	END
END
GO


IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PSALU_APointSale]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[PSALU_APointSale]

GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[PSALU_APointSale]
( 
	 @pintBUSI_Code				INT 
	,@pintBOFF_Code				INT 
	,@pintPSAL_Code				INT 
	,@pvchPSAL_Name				VARCHAR(100) 
	,@pbitPSAL_Main				BIT
	,@pchrPSAL_Status			CHAR(1) 
	,@pvchAUDI_ModificationUser	VARCHAR(20)
	,@pvchPSAL_ErrorMessage		VARCHAR(MAX) OUTPUT
)
AS 
BEGIN

	IF (@pbitPSAL_Main = 0 OR NOT EXISTS(SELECT PSAL_Code FROM dbo.VENPY_PointsSale 
											WHERE BUSI_Code = @pintBUSI_Code AND BOFF_Code = @pintBOFF_Code AND PSAL_Main = 1 AND PSAL_Code <> @pintPSAL_Code))
	BEGIN 
		IF NOT EXISTS (SELECT PSAL_Code FROM [VENPY_PointsSale] 
						WHERE BUSI_Code = @pintBUSI_Code AND BOFF_Code = @pintBOFF_Code AND RTRIM(LTRIM(PSAL_Name)) = RTRIM(LTRIM(@pvchPSAL_Name)) AND PSAL_Code <> @pintPSAL_Code )
		BEGIN
			UPDATE [VENPY_PointsSale]
			   SET [PSAL_Name]				= @pvchPSAL_Name
			     , [PSAL_Main]				= @pbitPSAL_Main
			     , [PSAL_Status]			= @pchrPSAL_Status
			     , [AUDI_ModificationUser]	= @pvchAUDI_ModificationUser
			     , [AUDI_ModificationDate]	= GETDATE()
			 WHERE 
				[BUSI_Code] = @pintBUSI_Code AND 
				[BOFF_Code] = @pintBOFF_Code AND 
				[PSAL_Code] = @pintPSAL_Code
		END
		ELSE
		BEGIN 
			SET @pvchPSAL_ErrorMessage = 'Ya existe un Punto de Venta que pertenece a la misma Sucursal con el nombre ' + @pvchPSAL_Name
		END
	END 
	ELSE
	BEGIN 
		SET @pvchPSAL_ErrorMessage = 'Ya existe un Punto de Venta principal para la misma Sucursal ' 
	END
		
END
GO