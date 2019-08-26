/********************************************************************************************************************/
/************************************************ TABLES ************************************************************/
/********************************************************************************************************************/
DECLARE @pintBUSI_Code INT 
	SET @pintBUSI_Code = 1 -- Code of Company


IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'TAB' AND [TBLE_Code] = 'TDO')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'TAB' , 'TDO' , NULL , '01' , 'TABLAS DE DOCUMENTOS' , NULL , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END 
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'TAB' AND [TBLE_Code] = 'MND')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'TAB' , 'MND' , NULL , '02' , 'TABLAS DE MONEDA' , NULL , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END 
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'TAB' AND [TBLE_Code] = 'TDI')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'TAB' , 'TDI' , NULL , '06' , 'TABLAS DE DOCUMENTOS DE IDENTIDAD' , NULL , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END 
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'TAB' AND [TBLE_Code] = 'TAI')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'TAB' , 'TAI' , NULL , '07' , 'TABLAS DE AFECTACION DEL IGV' , NULL , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END 
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'TAB' AND [TBLE_Code] = 'ALM')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'TAB' , 'ALM' , NULL , NULL , 'TABLAS DE ALMACENES' , NULL , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END 
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'TAB' AND [TBLE_Code] = 'FAP')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'TAB' , 'FAP' , NULL , NULL , 'TABLAS DE FAMILIAS DE PRODUCTOS' , NULL , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END 
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'TAB' AND [TBLE_Code] = 'FAS')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'TAB' , 'FAS' , NULL , NULL , 'TABLAS DE FAMILIAS DE SERVICIOS' , NULL , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END 
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'TAB' AND [TBLE_Code] = 'MAR')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'TAB' , 'MAR' , NULL , NULL , 'TABLAS DE MARCAS DE PRODUCTOS' , NULL , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END 
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'TAB' AND [TBLE_Code] = 'UNM')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'TAB' , 'UNM' , NULL , '03' , 'TABLAS DE UNIDADES DE MEDIDA' , NULL , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END 
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'TAB' AND [TBLE_Code] = 'PAI')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'TAB' , 'PAI' , NULL , '04' , 'TABLAS DE PAISES' , NULL , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END 
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'TAB' AND [TBLE_Code] = 'TAB')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'TAB' , 'TAB' , NULL , NULL , 'TABLAS' , NULL , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END 

/******************************************** TIPOS DE DOCUMENTOS ***************************************************/

IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'TDO' AND [TBLE_Code] = '001')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'TDO' , '001' , NULL , '01' , 'FACTURA' , NULL , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END 
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'TDO' AND [TBLE_Code] = '002')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'TDO' , '002' , NULL , '03' , 'BOLETA DE VENTA' , NULL , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END 
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'TDO' AND [TBLE_Code] = '003')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'TDO' , '003' , NULL , '07' , 'NOTA DE CREDITO' , NULL , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END 
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'TDO' AND [TBLE_Code] = '004')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'TDO' , '004' , NULL , '08' , 'NOTA DE DEBITO' , NULL , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END 

/********************************************** TIPOS DE MONEDAS ****************************************************/

IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'MND' AND [TBLE_Code] = '001')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'MND' , '001' , 'PEN' , 'PEN' , 'SOLES' , NULL , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END 
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'MND' AND [TBLE_Code] = '002')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'MND' , '002' , 'USD' , 'USD' , 'US DOLAR' , NULL , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END 

/*************************************** TIPOS DE DOCUMENTOS DE IDENTIDAD *******************************************/

IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'TDI' AND [TBLE_Code] = '001')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'TDI' , '001' , NULL , '0' , 'DOC.TRIB.NO.DOM.SIN.RUC' , NULL , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END 
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'TDI' AND [TBLE_Code] = '002')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'TDI' , '002' , NULL , '1' , 'DOC. NACIONAL DE IDENTIDAD' , NULL , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END 
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'TDI' AND [TBLE_Code] = '003')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'TDI' , '003' , NULL , '4' , 'CARNET DE EXTRANJERIA' , NULL , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END 
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'TDI' AND [TBLE_Code] = '004')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'TDI' , '004' , NULL , '6' , 'REG. UNICO DE CONTRIBUYENTES' , NULL , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END 
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'TDI' AND [TBLE_Code] = '005')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'TDI' , '005' , NULL , '7' , 'PASAPORTE' , NULL , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END 
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'TDI' AND [TBLE_Code] = '006')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'TDI' , '006' , NULL , 'A' , 'CED. DIPLOMATICA DE IDENTIDAD' , NULL , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END 

/***************************************** TIPOS DE AFECTACION DE IGV  **********************************************/

IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'TAI' AND [TBLE_Code] = '001')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'TAI' , '001' , NULL , '10' , 'GRAVADO' , 'GRAVADO - OPERACIÓN ONEROSA' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END 
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'TAI' AND [TBLE_Code] = '002')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'TAI' , '002' , NULL , '20' , 'EXONERADO' , 'EXONERADO - OPERACIÓN ONEROSA' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END 
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'TAI' AND [TBLE_Code] = '003')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'TAI' , '003' , NULL , '30' , 'INAFECTO' , 'INAFECTO - OPERACIÓN ONEROSA' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END 

/********************************************* UNIDADES DE MEDIDA ***************************************************/
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'UNM' AND [TBLE_Code] = '001')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'UNM' , '001' , 'NIU' , 'NIU' , 'UNI. MEDIDA ESTANDAR' , NULL , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END 

/************************************************* ALMACENES ********************************************************/
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'ALM' AND [TBLE_Code] = '001')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'ALM' , '001' , NULL , NULL , 'ALMACEN PRINCIPAL' , NULL , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END 

/************************************************** PAISES **********************************************************/

IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '001')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '001' , '248' , 'AX' , 'AALAND ISLANDS' , 'ALA' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '002')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '002' , '004' , 'AF' , 'AFGHANISTAN' , 'AFG' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '003')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '003' , '008' , 'AL' , 'ALBANIA' , 'ALB' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '004')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '004' , '012' , 'DZ' , 'ALGERIA' , 'DZA' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '005')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '005' , '016' , 'AS' , 'AMERICAN SAMOA' , 'ASM' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '006')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '006' , '020' , 'AD' , 'ANDORRA' , 'AND' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '007')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '007' , '024' , 'AO' , 'ANGOLA' , 'AGO' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '008')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '008' , '660' , 'AI' , 'ANGUILLA' , 'AIA' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '009')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '009' , '010' , 'AQ' , 'ANTARCTICA' , 'ATA' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '010')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '010' , '028' , 'AG' , 'ANTIGUA AND BARBUDA' , 'ATG' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '011')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '011' , '032' , 'AR' , 'ARGENTINA' , 'ARG' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '012')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '012' , '051' , 'AM' , 'ARMENIA' , 'ARM' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '013')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '013' , '533' , 'AW' , 'ARUBA' , 'ABW' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '014')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '014' , '036' , 'AU' , 'AUSTRALIA' , 'AUS' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '015')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '015' , '040' , 'AT' , 'AUSTRIA' , 'AUT' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '016')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '016' , '031' , 'AZ' , 'AZERBAIJAN' , 'AZE' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '017')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '017' , '044' , 'BS' , 'BAHAMAS' , 'BHS' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '018')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '018' , '048' , 'BH' , 'BAHRAIN' , 'BHR' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '019')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '019' , '050' , 'BD' , 'BANGLADESH' , 'BGD' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '020')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '020' , '052' , 'BB' , 'BARBADOS' , 'BRB' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '021')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '021' , '112' , 'BY' , 'BELARUS' , 'BLR' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '022')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '022' , '056' , 'BE' , 'BELGIUM' , 'BEL' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '023')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '023' , '084' , 'BZ' , 'BELIZE' , 'BLZ' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '024')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '024' , '204' , 'BJ' , 'BENIN' , 'BEN' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '025')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '025' , '060' , 'BM' , 'BERMUDA' , 'BMU' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '026')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '026' , '064' , 'BT' , 'BHUTAN' , 'BTN' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '027')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '027' , '068' , 'BO' , 'BOLIVIA' , 'BOL' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '028')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '028' , '070' , 'BA' , 'BOSNIA AND HERZEGOWINA' , 'BIH' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '029')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '029' , '072' , 'BW' , 'BOTSWANA' , 'BWA' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '030')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '030' , '074' , 'BV' , 'BOUVET ISLAND' , 'BVT' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '031')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '031' , '076' , 'BR' , 'BRAZIL' , 'BRA' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '032')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '032' , '086' , 'IO' , 'BRITISH INDIAN OCEAN TERRITORY' , 'IOT' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '033')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '033' , '096' , 'BN' , 'BRUNEI DARUSSALAM' , 'BRN' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '034')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '034' , '100' , 'BG' , 'BULGARIA' , 'BGR' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '035')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '035' , '854' , 'BF' , 'BURKINA FASO' , 'BFA' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '036')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '036' , '108' , 'BI' , 'BURUNDI' , 'BDI' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '037')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '037' , '116' , 'KH' , 'CAMBODIA' , 'KHM' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '038')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '038' , '120' , 'CM' , 'CAMEROON' , 'CMR' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '039')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '039' , '124' , 'CA' , 'CANADA' , 'CAN' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '040')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '040' , '132' , 'CV' , 'CAPE VERDE' , 'CPV' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '041')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '041' , '136' , 'KY' , 'CAYMAN ISLANDS' , 'CYM' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '042')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '042' , '140' , 'CF' , 'CENTRAL AFRICAN REPUBLIC' , 'CAF' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '043')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '043' , '148' , 'TD' , 'CHAD' , 'TCD' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '044')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '044' , '152' , 'CL' , 'CHILE' , 'CHL' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '045')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '045' , '156' , 'CN' , 'CHINA' , 'CHN' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '046')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '046' , '162' , 'CX' , 'CHRISTMAS ISLAND' , 'CXR' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '047')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '047' , '166' , 'CC' , 'COCOS (KEELING) ISLANDS' , 'CCK' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '048')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '048' , '170' , 'CO' , 'COLOMBIA' , 'COL' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '049')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '049' , '174' , 'KM' , 'COMOROS' , 'COM' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '050')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '050' , '180' , 'CD' , 'CONGO, DEMOCRATIC REPUBLIC OF (WAS ZAIRE)' , 'COD' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '051')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '051' , '178' , 'CG' , 'CONGO, REPUBLIC OF' , 'COG' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '052')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '052' , '184' , 'CK' , 'COOK ISLANDS' , 'COK' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '053')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '053' , '188' , 'CR' , 'COSTA RICA' , 'CRI' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '054')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '054' , '384' , 'CI' , 'COTE D''IVOIRE' , 'CIV' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '055')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '055' , '191' , 'HR' , 'CROATIA (LOCAL NAME: HRVATSKA)' , 'HRV' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '056')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '056' , '192' , 'CU' , 'CUBA' , 'CUB' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '057')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '057' , '196' , 'CY' , 'CYPRUS' , 'CYP' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '058')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '058' , '203' , 'CZ' , 'CZECH REPUBLIC' , 'CZE' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '059')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '059' , '208' , 'DK' , 'DENMARK' , 'DNK' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '060')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '060' , '262' , 'DJ' , 'DJIBOUTI' , 'DJI' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '061')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '061' , '212' , 'DM' , 'DOMINICA' , 'DMA' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '062')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '062' , '214' , 'DO' , 'DOMINICAN REPUBLIC' , 'DOM' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '063')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '063' , '218' , 'EC' , 'ECUADOR' , 'ECU' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '064')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '064' , '818' , 'EG' , 'EGYPT' , 'EGY' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '065')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '065' , '222' , 'SV' , 'EL SALVADOR' , 'SLV' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '066')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '066' , '226' , 'GQ' , 'EQUATORIAL GUINEA' , 'GNQ' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '067')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '067' , '232' , 'ER' , 'ERITREA' , 'ERI' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '068')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '068' , '233' , 'EE' , 'ESTONIA' , 'EST' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '069')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '069' , '231' , 'ET' , 'ETHIOPIA' , 'ETH' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '070')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '070' , '238' , 'FK' , 'FALKLAND ISLANDS (MALVINAS)' , 'FLK' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '071')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '071' , '234' , 'FO' , 'FAROE ISLANDS' , 'FRO' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '072')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '072' , '242' , 'FJ' , 'FIJI' , 'FJI' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '073')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '073' , '246' , 'FI' , 'FINLAND' , 'FIN' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '074')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '074' , '250' , 'FR' , 'FRANCE' , 'FRA' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '075')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '075' , '254' , 'GF' , 'FRENCH GUIANA' , 'GUF' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '076')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '076' , '258' , 'PF' , 'FRENCH POLYNESIA' , 'PYF' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '077')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '077' , '260' , 'TF' , 'FRENCH SOUTHERN TERRITORIES' , 'ATF' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '078')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '078' , '266' , 'GA' , 'GABON' , 'GAB' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '079')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '079' , '270' , 'GM' , 'GAMBIA' , 'GMB' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '080')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '080' , '268' , 'GE' , 'GEORGIA' , 'GEO' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '081')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '081' , '276' , 'DE' , 'GERMANY' , 'DEU' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '082')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '082' , '288' , 'GH' , 'GHANA' , 'GHA' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '083')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '083' , '292' , 'GI' , 'GIBRALTAR' , 'GIB' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '084')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '084' , '300' , 'GR' , 'GREECE' , 'GRC' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '085')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '085' , '304' , 'GL' , 'GREENLAND' , 'GRL' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '086')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '086' , '308' , 'GD' , 'GRENADA' , 'GRD' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '087')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '087' , '312' , 'GP' , 'GUADELOUPE' , 'GLP' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '088')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '088' , '316' , 'GU' , 'GUAM' , 'GUM' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '089')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '089' , '320' , 'GT' , 'GUATEMALA' , 'GTM' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '090')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '090' , '324' , 'GN' , 'GUINEA' , 'GIN' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '091')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '091' , '624' , 'GW' , 'GUINEA-BISSAU' , 'GNB' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '092')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '092' , '328' , 'GY' , 'GUYANA' , 'GUY' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '093')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '093' , '332' , 'HT' , 'HAITI' , 'HTI' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '094')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '094' , '334' , 'HM' , 'HEARD AND MC DONALD ISLANDS' , 'HMD' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '095')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '095' , '340' , 'HN' , 'HONDURAS' , 'HND' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '096')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '096' , '344' , 'HK' , 'HONG KONG' , 'HKG' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '097')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '097' , '348' , 'HU' , 'HUNGARY' , 'HUN' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '098')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '098' , '352' , 'IS' , 'ICELAND' , 'ISL' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '099')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '099' , '356' , 'IN' , 'INDIA' , 'IND' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '100')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '100' , '360' , 'ID' , 'INDONESIA' , 'IDN' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '101')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '101' , '364' , 'IR' , 'IRAN (ISLAMIC REPUBLIC OF)' , 'IRN' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '102')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '102' , '368' , 'IQ' , 'IRAQ' , 'IRQ' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '103')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '103' , '372' , 'IE' , 'IRELAND' , 'IRL' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '104')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '104' , '376' , 'IL' , 'ISRAEL' , 'ISR' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '105')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '105' , '380' , 'IT' , 'ITALY' , 'ITA' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '106')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '106' , '388' , 'JM' , 'JAMAICA' , 'JAM' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '107')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '107' , '392' , 'JP' , 'JAPAN' , 'JPN' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '108')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '108' , '400' , 'JO' , 'JORDAN' , 'JOR' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '109')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '109' , '398' , 'KZ' , 'KAZAKHSTAN' , 'KAZ' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '110')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '110' , '404' , 'KE' , 'KENYA' , 'KEN' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '111')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '111' , '296' , 'KI' , 'KIRIBATI' , 'KIR' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '112')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '112' , '408' , 'KP' , 'KOREA, DEMOCRATIC PEOPLE''S REPUBLIC OF' , 'PRK' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '113')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '113' , '410' , 'KR' , 'KOREA, REPUBLIC OF' , 'KOR' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '114')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '114' , '414' , 'KW' , 'KUWAIT' , 'KWT' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '115')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '115' , '417' , 'KG' , 'KYRGYZSTAN' , 'KGZ' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '116')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '116' , '418' , 'LA' , 'LAO PEOPLE''S DEMOCRATIC REPUBLIC' , 'LAO' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '117')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '117' , '428' , 'LV' , 'LATVIA' , 'LVA' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '118')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '118' , '422' , 'LB' , 'LEBANON' , 'LBN' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '119')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '119' , '426' , 'LS' , 'LESOTHO' , 'LSO' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '120')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '120' , '430' , 'LR' , 'LIBERIA' , 'LBR' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '121')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '121' , '434' , 'LY' , 'LIBYAN ARAB JAMAHIRIYA' , 'LBY' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '122')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '122' , '438' , 'LI' , 'LIECHTENSTEIN' , 'LIE' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '123')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '123' , '440' , 'LT' , 'LITHUANIA' , 'LTU' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '124')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '124' , '442' , 'LU' , 'LUXEMBOURG' , 'LUX' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '125')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '125' , '446' , 'MO' , 'MACAU' , 'MAC' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '126')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '126' , '807' , 'MK' , 'MACEDONIA, THE FORMER YUGOSLAV REPUBLIC OF' , 'MKD' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '127')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '127' , '450' , 'MG' , 'MADAGASCAR' , 'MDG' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '128')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '128' , '454' , 'MW' , 'MALAWI' , 'MWI' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '129')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '129' , '458' , 'MY' , 'MALAYSIA' , 'MYS' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '130')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '130' , '462' , 'MV' , 'MALDIVES' , 'MDV' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '131')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '131' , '466' , 'ML' , 'MALI' , 'MLI' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '132')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '132' , '470' , 'MT' , 'MALTA' , 'MLT' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '133')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '133' , '584' , 'MH' , 'MARSHALL ISLANDS' , 'MHL' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '134')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '134' , '474' , 'MQ' , 'MARTINIQUE' , 'MTQ' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '135')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '135' , '478' , 'MR' , 'MAURITANIA' , 'MRT' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '136')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '136' , '480' , 'MU' , 'MAURITIUS' , 'MUS' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '137')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '137' , '175' , 'YT' , 'MAYOTTE' , 'MYT' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '138')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '138' , '484' , 'MX' , 'MEXICO' , 'MEX' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '139')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '139' , '583' , 'FM' , 'MICRONESIA, FEDERATED STATES OF' , 'FSM' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '140')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '140' , '498' , 'MD' , 'MOLDOVA, REPUBLIC OF' , 'MDA' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '141')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '141' , '492' , 'MC' , 'MONACO' , 'MCO' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '142')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '142' , '496' , 'MN' , 'MONGOLIA' , 'MNG' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '143')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '143' , '500' , 'MS' , 'MONTSERRAT' , 'MSR' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '144')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '144' , '504' , 'MA' , 'MOROCCO' , 'MAR' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '145')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '145' , '508' , 'MZ' , 'MOZAMBIQUE' , 'MOZ' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '146')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '146' , '104' , 'MM' , 'MYANMAR' , 'MMR' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '147')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '147' , '516' , 'NA' , 'NAMIBIA' , 'NAM' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '148')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '148' , '520' , 'NR' , 'NAURU' , 'NRU' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '149')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '149' , '524' , 'NP' , 'NEPAL' , 'NPL' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '150')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '150' , '528' , 'NL' , 'NETHERLANDS' , 'NLD' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '151')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '151' , '530' , 'AN' , 'NETHERLANDS ANTILLES' , 'ANT' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '152')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '152' , '540' , 'NC' , 'NEW CALEDONIA' , 'NCL' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '153')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '153' , '554' , 'NZ' , 'NEW ZEALAND' , 'NZL' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '154')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '154' , '558' , 'NI' , 'NICARAGUA' , 'NIC' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '155')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '155' , '562' , 'NE' , 'NIGER' , 'NER' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '156')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '156' , '566' , 'NG' , 'NIGERIA' , 'NGA' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '157')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '157' , '570' , 'NU' , 'NIUE' , 'NIU' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '158')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '158' , '574' , 'NF' , 'NORFOLK ISLAND' , 'NFK' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '159')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '159' , '580' , 'MP' , 'NORTHERN MARIANA ISLANDS' , 'MNP' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '160')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '160' , '578' , 'NO' , 'NORWAY' , 'NOR' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '161')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '161' , '512' , 'OM' , 'OMAN' , 'OMN' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '162')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '162' , '586' , 'PK' , 'PAKISTAN' , 'PAK' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '163')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '163' , '585' , 'PW' , 'PALAU' , 'PLW' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '164')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '164' , '275' , 'PS' , 'PALESTINIAN TERRITORY, OCCUPIED' , 'PSE' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '165')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '165' , '591' , 'PA' , 'PANAMA' , 'PAN' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '166')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '166' , '598' , 'PG' , 'PAPUA NEW GUINEA' , 'PNG' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '167')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '167' , '600' , 'PY' , 'PARAGUAY' , 'PRY' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '168')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '168' , '604' , 'PE' , 'PERU' , 'PER' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '169')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '169' , '608' , 'PH' , 'PHILIPPINES' , 'PHL' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '170')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '170' , '612' , 'PN' , 'PITCAIRN' , 'PCN' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '171')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '171' , '616' , 'PL' , 'POLAND' , 'POL' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '172')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '172' , '620' , 'PT' , 'PORTUGAL' , 'PRT' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '173')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '173' , '630' , 'PR' , 'PUERTO RICO' , 'PRI' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '174')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '174' , '634' , 'QA' , 'QATAR' , 'QAT' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '175')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '175' , '638' , 'RE' , 'REUNION' , 'REU' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '176')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '176' , '642' , 'RO' , 'ROMANIA' , 'ROU' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '177')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '177' , '643' , 'RU' , 'RUSSIAN FEDERATION' , 'RUS' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '178')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '178' , '646' , 'RW' , 'RWANDA' , 'RWA' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '179')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '179' , '654' , 'SH' , 'SAINT HELENA' , 'SHN' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '180')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '180' , '659' , 'KN' , 'SAINT KITTS AND NEVIS' , 'KNA' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '181')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '181' , '662' , 'LC' , 'SAINT LUCIA' , 'LCA' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '182')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '182' , '666' , 'PM' , 'SAINT PIERRE AND MIQUELON' , 'SPM' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '183')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '183' , '670' , 'VC' , 'SAINT VINCENT AND THE GRENADINES' , 'VCT' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '184')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '184' , '882' , 'WS' , 'SAMOA' , 'WSM' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '185')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '185' , '674' , 'SM' , 'SAN MARINO' , 'SMR' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '186')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '186' , '678' , 'ST' , 'SAO TOME AND PRINCIPE' , 'STP' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '187')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '187' , '682' , 'SA' , 'SAUDI ARABIA' , 'SAU' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '188')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '188' , '686' , 'SN' , 'SENEGAL' , 'SEN' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '189')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '189' , '891' , 'CS' , 'SERBIA AND MONTENEGRO' , 'SCG' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '190')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '190' , '690' , 'SC' , 'SEYCHELLES' , 'SYC' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '191')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '191' , '694' , 'SL' , 'SIERRA LEONE' , 'SLE' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '192')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '192' , '702' , 'SG' , 'SINGAPORE' , 'SGP' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '193')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '193' , '703' , 'SK' , 'SLOVAKIA' , 'SVK' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '194')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '194' , '705' , 'SI' , 'SLOVENIA' , 'SVN' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '195')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '195' , '090' , 'SB' , 'SOLOMON ISLANDS' , 'SLB' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '196')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '196' , '706' , 'SO' , 'SOMALIA' , 'SOM' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '197')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '197' , '710' , 'ZA' , 'SOUTH AFRICA' , 'ZAF' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '198')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '198' , '239' , 'GS' , 'SOUTH GEORGIA AND THE SOUTH SANDWICH ISLANDS' , 'SGS' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '199')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '199' , '724' , 'ES' , 'SPAIN' , 'ESP' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '200')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '200' , '144' , 'LK' , 'SRI LANKA' , 'LKA' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '201')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '201' , '736' , 'SD' , 'SUDAN' , 'SDN' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '202')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '202' , '740' , 'SR' , 'SURINAME' , 'SUR' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '203')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '203' , '744' , 'SJ' , 'SVALBARD AND JAN MAYEN ISLANDS' , 'SJM' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '204')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '204' , '748' , 'SZ' , 'SWAZILAND' , 'SWZ' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '205')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '205' , '752' , 'SE' , 'SWEDEN' , 'SWE' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '206')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '206' , '756' , 'CH' , 'SWITZERLAND' , 'CHE' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '207')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '207' , '760' , 'SY' , 'SYRIAN ARAB REPUBLIC' , 'SYR' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '208')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '208' , '158' , 'TW' , 'TAIWAN' , 'TWN' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '209')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '209' , '762' , 'TJ' , 'TAJIKISTAN' , 'TJK' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '210')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '210' , '834' , 'TZ' , 'TANZANIA, UNITED REPUBLIC OF' , 'TZA' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '211')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '211' , '764' , 'TH' , 'THAILAND' , 'THA' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '212')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '212' , '626' , 'TL' , 'TIMOR-LESTE' , 'TLS' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '213')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '213' , '768' , 'TG' , 'TOGO' , 'TGO' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '214')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '214' , '772' , 'TK' , 'TOKELAU' , 'TKL' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '215')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '215' , '776' , 'TO' , 'TONGA' , 'TON' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '216')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '216' , '780' , 'TT' , 'TRINIDAD AND TOBAGO' , 'TTO' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '217')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '217' , '788' , 'TN' , 'TUNISIA' , 'TUN' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '218')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '218' , '792' , 'TR' , 'TURKEY' , 'TUR' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '219')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '219' , '795' , 'TM' , 'TURKMENISTAN' , 'TKM' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '220')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '220' , '796' , 'TC' , 'TURKS AND CAICOS ISLANDS' , 'TCA' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '221')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '221' , '798' , 'TV' , 'TUVALU' , 'TUV' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '222')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '222' , '800' , 'UG' , 'UGANDA' , 'UGA' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '223')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '223' , '804' , 'UA' , 'UKRAINE' , 'UKR' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '224')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '224' , '784' , 'AE' , 'UNITED ARAB EMIRATES' , 'ARE' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '225')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '225' , '826' , 'GB' , 'UNITED KINGDOM' , 'GBR' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '226')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '226' , '840' , 'US' , 'UNITED STATES' , 'USA' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '227')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '227' , '581' , 'UM' , 'UNITED STATES MINOR OUTLYING ISLANDS' , 'UMI' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '228')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '228' , '858' , 'UY' , 'URUGUAY' , 'URY' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '229')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '229' , '860' , 'UZ' , 'UZBEKISTAN' , 'UZB' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '230')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '230' , '548' , 'VU' , 'VANUATU' , 'VUT' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '231')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '231' , '336' , 'VA' , 'VATICAN CITY STATE (HOLY SEE)' , 'VAT' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '232')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '232' , '862' , 'VE' , 'VENEZUELA' , 'VEN' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '233')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '233' , '704' , 'VN' , 'VIET NAM' , 'VNM' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '234')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '234' , '092' , 'VG' , 'VIRGIN ISLANDS (BRITISH)' , 'VGB' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '235')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '235' , '850' , 'VI' , 'VIRGIN ISLANDS (U.S.)' , 'VIR' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '236')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '236' , '876' , 'WF' , 'WALLIS AND FUTUNA ISLANDS' , 'WLF' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '237')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '237' , '732' , 'EH' , 'WESTERN SAHARA' , 'ESH' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '238')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '238' , '887' , 'YE' , 'YEMEN' , 'YEM' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '239')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '239' , '894' , 'ZM' , 'ZAMBIA' , 'ZMB' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END
IF NOT EXISTS (SELECT * FROM [dbo].[VENPY_Tables] WHERE [BUSI_Code] = @pintBUSI_Code AND [TBLE_Table] = 'PAI' AND [TBLE_Code] = '240')
	BEGIN
		INSERT INTO [dbo].[VENPY_Tables] ( [BUSI_Code] , [TBLE_Table] , [TBLE_Code] , [TBLE_InternationalCode] , [TBLE_SunatCode] , [TBLE_Description1] , [TBLE_Description2] , [TBLE_Number1] , [TBLE_Number2] , [TBLE_Status] , [TBLE_Default] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
			VALUES  ( @pintBUSI_Code , 'PAI' , '240' , '716' , 'ZW' , 'ZIMBABWE' , 'ZWE' , NULL , NULL , 'A' , 1 , 'SISTEMAS' , GETDATE() , NULL , NULL )
	END

/********************************************************************************************************************/
/********************************************************************************************************************/

