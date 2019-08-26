/********************************************************************************************************************/
/*************************************** PERSONAL CONFIGURATION *****************************************************/
/********************************************************************************************************************/

DECLARE @pintBUSI_Code INT , @pintUSER_Code INT 
	SET @pintBUSI_Code = 1 -- Code of Company
	SET @pintUSER_Code = 1 -- Code of User

IF NOT EXISTS(SELECT * FROM [dbo].[VENPY_PersonalConfiguration] WHERE [BUSI_Code] = @pintBUSI_Code AND [USER_Code] = @pintUSER_Code AND [PCON_Key] = 'PTXT' )
	BEGIN 
		INSERT [dbo].[VENPY_PersonalConfiguration] ([BUSI_Code], [USER_Code], [PCON_Key], [PCON_Value], [PCON_Description], [AUDI_CreationUser], [AUDI_CreationDate], [AUDI_ModificationUser], [AUDI_ModificationDate]) 
			VALUES (@pintBUSI_Code, @pintUSER_Code , N'PTXT', N'200', N'CANTIDAD MAXIMA DE FILAS EN ARCHIVO TXT', N'SISTEMAS', GETDATE(), NULL, NULL)
	END  
IF NOT EXISTS(SELECT * FROM [dbo].[VENPY_PersonalConfiguration] WHERE [BUSI_Code] = @pintBUSI_Code AND [USER_Code] = @pintUSER_Code AND [PCON_Key] = 'PXLS' )
	BEGIN 		
		INSERT [dbo].[VENPY_PersonalConfiguration] ([BUSI_Code], [USER_Code], [PCON_Key], [PCON_Value], [PCON_Description], [AUDI_CreationUser], [AUDI_CreationDate], [AUDI_ModificationUser], [AUDI_ModificationDate]) 
			VALUES (@pintBUSI_Code, @pintUSER_Code , N'PXLS', N'1', N'EXPORTAR A EXCEL', N'SISTEMAS', GETDATE(), NULL, NULL)
	END 
IF NOT EXISTS(SELECT * FROM [dbo].[VENPY_PersonalConfiguration] WHERE [BUSI_Code] = @pintBUSI_Code AND [USER_Code] = @pintUSER_Code AND [PCON_Key] = 'PCDD' )
	BEGIN 		
		INSERT [dbo].[VENPY_PersonalConfiguration] ([BUSI_Code], [USER_Code], [PCON_Key], [PCON_Value], [PCON_Description], [AUDI_CreationUser], [AUDI_CreationDate], [AUDI_ModificationUser], [AUDI_ModificationDate]) 
			VALUES (@pintBUSI_Code, @pintUSER_Code , N'PCDD', N'2', N'CANTIDAD DE DECIMALES (DETALLE)', N'SISTEMAS', GETDATE(), NULL, NULL)
	END 
IF NOT EXISTS(SELECT * FROM [dbo].[VENPY_PersonalConfiguration] WHERE [BUSI_Code] = @pintBUSI_Code AND [USER_Code] = @pintUSER_Code AND [PCON_Key] = 'PCDT' )
	BEGIN 		
		INSERT [dbo].[VENPY_PersonalConfiguration] ([BUSI_Code], [USER_Code], [PCON_Key], [PCON_Value], [PCON_Description], [AUDI_CreationUser], [AUDI_CreationDate], [AUDI_ModificationUser], [AUDI_ModificationDate]) 
			VALUES (@pintBUSI_Code, @pintUSER_Code , N'PCDT', N'2', N'CANTIDAD DE DECIMALES (TOTALES)', N'SISTEMAS', GETDATE(), NULL, NULL)
	END
IF NOT EXISTS(SELECT * FROM [dbo].[VENPY_PersonalConfiguration] WHERE [BUSI_Code] = @pintBUSI_Code AND [USER_Code] = @pintUSER_Code AND [PCON_Key] = 'PIMP' )
	BEGIN 		
		INSERT [dbo].[VENPY_PersonalConfiguration] ([BUSI_Code], [USER_Code], [PCON_Key], [PCON_Value], [PCON_Description], [AUDI_CreationUser], [AUDI_CreationDate], [AUDI_ModificationUser], [AUDI_ModificationDate]) 
			VALUES (@pintBUSI_Code, @pintUSER_Code , N'PIMP', N'1', N'IMPRIMIR AL GUARDAR', N'SISTEMAS', GETDATE(), NULL, NULL)
	END 
IF NOT EXISTS(SELECT * FROM [dbo].[VENPY_PersonalConfiguration] WHERE [BUSI_Code] = @pintBUSI_Code AND [USER_Code] = @pintUSER_Code AND [PCON_Key] = 'PLPR' )
	BEGIN 		
		INSERT [dbo].[VENPY_PersonalConfiguration] ([BUSI_Code], [USER_Code], [PCON_Key], [PCON_Value], [PCON_Description], [AUDI_CreationUser], [AUDI_CreationDate], [AUDI_ModificationUser], [AUDI_ModificationDate]) 
			VALUES (@pintBUSI_Code, @pintUSER_Code , N'PLPR', N'', N'LISTAS DE PRECIO ASIGNADAS', N'SISTEMAS', GETDATE(), NULL, NULL)
	END 
IF NOT EXISTS(SELECT * FROM [dbo].[VENPY_PersonalConfiguration] WHERE [BUSI_Code] = @pintBUSI_Code AND [USER_Code] = @pintUSER_Code AND [PCON_Key] = 'PSFA' )
	BEGIN 		
		INSERT [dbo].[VENPY_PersonalConfiguration] ([BUSI_Code], [USER_Code], [PCON_Key], [PCON_Value], [PCON_Description], [AUDI_CreationUser], [AUDI_CreationDate], [AUDI_ModificationUser], [AUDI_ModificationDate]) 
			VALUES (@pintBUSI_Code, @pintUSER_Code , N'PSFA', N'', N'LISTAS DE SERIES DE FACTURAS', N'SISTEMAS', GETDATE(), NULL, NULL)
	END 
IF NOT EXISTS(SELECT * FROM [dbo].[VENPY_PersonalConfiguration] WHERE [BUSI_Code] = @pintBUSI_Code AND [USER_Code] = @pintUSER_Code AND [PCON_Key] = 'PSBO' )
	BEGIN 		
		INSERT [dbo].[VENPY_PersonalConfiguration] ([BUSI_Code], [USER_Code], [PCON_Key], [PCON_Value], [PCON_Description], [AUDI_CreationUser], [AUDI_CreationDate], [AUDI_ModificationUser], [AUDI_ModificationDate]) 
			VALUES (@pintBUSI_Code, @pintUSER_Code , N'PSBO', N'', N'LISTAS DE SERIES DE BOLETAS', N'SISTEMAS', GETDATE(), NULL, NULL)
	END 
IF NOT EXISTS(SELECT * FROM [dbo].[VENPY_PersonalConfiguration] WHERE [BUSI_Code] = @pintBUSI_Code AND [USER_Code] = @pintUSER_Code AND [PCON_Key] = 'PSNC' )
	BEGIN 		
		INSERT [dbo].[VENPY_PersonalConfiguration] ([BUSI_Code], [USER_Code], [PCON_Key], [PCON_Value], [PCON_Description], [AUDI_CreationUser], [AUDI_CreationDate], [AUDI_ModificationUser], [AUDI_ModificationDate]) 
			VALUES (@pintBUSI_Code, @pintUSER_Code , N'PSNC', N'', N'LISTAS DE SERIES DE NOTAS DE CREDITO', N'SISTEMAS', GETDATE(), NULL, NULL)
	END 
IF NOT EXISTS(SELECT * FROM [dbo].[VENPY_PersonalConfiguration] WHERE [BUSI_Code] = @pintBUSI_Code AND [USER_Code] = @pintUSER_Code AND [PCON_Key] = 'PSND' )
	BEGIN 		
		INSERT [dbo].[VENPY_PersonalConfiguration] ([BUSI_Code], [USER_Code], [PCON_Key], [PCON_Value], [PCON_Description], [AUDI_CreationUser], [AUDI_CreationDate], [AUDI_ModificationUser], [AUDI_ModificationDate]) 
			VALUES (@pintBUSI_Code, @pintUSER_Code , N'PSND', N'', N'LISTAS DE SERIES DE NOTAS DE DEBITO', N'SISTEMAS', GETDATE(), NULL, NULL)
	END 
IF NOT EXISTS(SELECT * FROM [dbo].[VENPY_PersonalConfiguration] WHERE [BUSI_Code] = @pintBUSI_Code AND [USER_Code] = @pintUSER_Code AND [PCON_Key] = 'PMPR' )
	BEGIN 		
		INSERT [dbo].[VENPY_PersonalConfiguration] ([BUSI_Code], [USER_Code], [PCON_Key], [PCON_Value], [PCON_Description], [AUDI_CreationUser], [AUDI_CreationDate], [AUDI_ModificationUser], [AUDI_ModificationDate]) 
			VALUES (@pintBUSI_Code, @pintUSER_Code , N'PMPR', N'0', N'MODIFICAR PRECIOS', N'SISTEMAS', GETDATE(), NULL, NULL)
	END 
IF NOT EXISTS(SELECT * FROM [dbo].[VENPY_PersonalConfiguration] WHERE [BUSI_Code] = @pintBUSI_Code AND [USER_Code] = @pintUSER_Code AND [PCON_Key] = 'PDSC' )
	BEGIN 		
		INSERT [dbo].[VENPY_PersonalConfiguration] ([BUSI_Code], [USER_Code], [PCON_Key], [PCON_Value], [PCON_Description], [AUDI_CreationUser], [AUDI_CreationDate], [AUDI_ModificationUser], [AUDI_ModificationDate]) 
			VALUES (@pintBUSI_Code, @pintUSER_Code , N'PDSC', N'0', N'APLICAR DESCUENTOS', N'SISTEMAS', GETDATE(), NULL, NULL)
	END
IF NOT EXISTS(SELECT * FROM [dbo].[VENPY_PersonalConfiguration] WHERE [BUSI_Code] = @pintBUSI_Code AND [USER_Code] = @pintUSER_Code AND [PCON_Key] = 'PPOV' )
	BEGIN 		
		INSERT [dbo].[VENPY_PersonalConfiguration] ([BUSI_Code], [USER_Code], [PCON_Key], [PCON_Value], [PCON_Description], [AUDI_CreationUser], [AUDI_CreationDate], [AUDI_ModificationUser], [AUDI_ModificationDate]) 
			VALUES (@pintBUSI_Code, @pintUSER_Code , N'PPOV', N'P', N'TRABAJAR CON PRECIO O VALOR DE VENTA ', N'SISTEMAS', GETDATE(), NULL, NULL)
	END 
IF NOT EXISTS(SELECT * FROM [dbo].[VENPY_PersonalConfiguration] WHERE [BUSI_Code] = @pintBUSI_Code AND [USER_Code] = @pintUSER_Code AND [PCON_Key] = 'PASP' )
	BEGIN 		
		INSERT [dbo].[VENPY_PersonalConfiguration] ([BUSI_Code], [USER_Code], [PCON_Key], [PCON_Value], [PCON_Description], [AUDI_CreationUser], [AUDI_CreationDate], [AUDI_ModificationUser], [AUDI_ModificationDate]) 
			VALUES (@pintBUSI_Code, @pintUSER_Code , N'PASP', N'A', N'TRABAJAR CON SERVIOS Y/O PRODUCTOS', N'SISTEMAS', GETDATE(), NULL, NULL)
	END

/********************************************************************************************************************/
/******************************************** AJUSTES GENERALES *****************************************************/
/********************************************************************************************************************/

IF NOT EXISTS(SELECT * FROM [dbo].[VENPY_Settings] WHERE [BUSI_Code] = @pintBUSI_Code AND [SETT_Key] = 'SEND')
	BEGIN
		INSERT [dbo].[VENPY_Settings] ( [BUSI_Code] , [SETT_Key] , [SETT_Value] , [SETT_Description] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
		VALUES  ( @pintBUSI_Code , N'SEND', N'', N'USUARIO DESCONOCIDO', N'SISTEMAS', GETDATE(), NULL, NULL)
	END 
IF NOT EXISTS(SELECT * FROM [dbo].[VENPY_Settings] WHERE [BUSI_Code] = @pintBUSI_Code AND [SETT_Key] = 'SIGV')
	BEGIN
		INSERT [dbo].[VENPY_Settings] ( [BUSI_Code] , [SETT_Key] , [SETT_Value] , [SETT_Description] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
		VALUES  ( @pintBUSI_Code , N'SIGV', N'18.00', N'PORCETAJE DEL IGV', N'SISTEMAS', GETDATE(), NULL, NULL)
	END
IF NOT EXISTS(SELECT * FROM [dbo].[VENPY_Settings] WHERE [BUSI_Code] = @pintBUSI_Code AND [SETT_Key] = 'SALI')
	BEGIN
		INSERT [dbo].[VENPY_Settings] ( [BUSI_Code] , [SETT_Key] , [SETT_Value] , [SETT_Description] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
		VALUES  ( @pintBUSI_Code , N'SALI', N'1', N'ACTUALIZAR LISTAS TEMPORALES AL INICIAR', N'SISTEMAS', GETDATE(), NULL, NULL)
	END	
IF NOT EXISTS(SELECT * FROM [dbo].[VENPY_Settings] WHERE [BUSI_Code] = @pintBUSI_Code AND [SETT_Key] = 'STCO')
	BEGIN
		INSERT [dbo].[VENPY_Settings] ( [BUSI_Code] , [SETT_Key] , [SETT_Value] , [SETT_Description] , [AUDI_CreationUser] , [AUDI_CreationDate] , [AUDI_ModificationUser] , [AUDI_ModificationDate] )
		VALUES  ( @pintBUSI_Code , N'STCO', N'1', N'TIPO DE CAMBIO OFICIAL', N'SISTEMAS', GETDATE(), NULL, NULL)
	END	 

/********************************************************************************************************************/
/********************************************** ENTITY TYPES ********************************************************/
/********************************************************************************************************************/

IF NOT EXISTS(SELECT * FROM [dbo].[VENPY_EntityTypes] WHERE [BUSI_Code] = @pintBUSI_Code AND [ETYP_Code] = 1 AND [ETYP_Name] = N'GERENCIA' )
	BEGIN 
		INSERT INTO [dbo].[VENPY_EntityTypes] ( BUSI_Code , ETYP_Code , ETYP_Name , ETYP_Description , ETYP_Active , ETYP_Default , AUDI_CreationUser , AUDI_CreationDate , AUDI_ModificationUser , AUDI_ModificationDate )
			VALUES  ( @pintBUSI_Code , 1 , N'GERENCIA' , N'PERSONAS QUE SE ENCARGAN DE DIRIGIR, GESTIONAR O ADMINISTRAR UNA SOCIEDAD, EMPRESA U OTRA ENTIDAD' , 1 , 1 , N'SISTEMAS' , GETDATE() , NULL , NULL )
	END 

IF NOT EXISTS(SELECT * FROM [dbo].[VENPY_EntityTypes] WHERE [BUSI_Code] = @pintBUSI_Code AND [ETYP_Code] = 2 AND [ETYP_Name] = N'CLIENTES' )
	BEGIN 
		INSERT INTO [dbo].[VENPY_EntityTypes] ( BUSI_Code , ETYP_Code , ETYP_Name , ETYP_Description , ETYP_Active , ETYP_Default , AUDI_CreationUser , AUDI_CreationDate , AUDI_ModificationUser , AUDI_ModificationDate )
			VALUES  ( @pintBUSI_Code , 2 , N'CLIENTES' , N'PERSONAS QUE COMPRAN EN UN ESTABLECIMIENTO COMERCIAL O PÚBLICO' , 1 , 1 , N'SISTEMAS' , GETDATE() , NULL , NULL )
	END 

IF NOT EXISTS(SELECT * FROM [dbo].[VENPY_EntityTypes] WHERE [BUSI_Code] = @pintBUSI_Code AND [ETYP_Code] = 3 AND [ETYP_Name] = N'PROVEEDORES' )
	BEGIN 
		INSERT INTO [dbo].[VENPY_EntityTypes] ( BUSI_Code , ETYP_Code , ETYP_Name , ETYP_Description , ETYP_Active , ETYP_Default , AUDI_CreationUser , AUDI_CreationDate , AUDI_ModificationUser , AUDI_ModificationDate )
			VALUES  ( @pintBUSI_Code , 3 , N'PROVEEDORES' , N'PERSONAS QUE SE DEDICAN A PROVEER O ABASTECER DE PRODUCTOS NECESARIOS A UNA PERSONA O EMPRESA' , 1 , 1 , N'SISTEMAS' , GETDATE() , NULL , NULL )
	END 

IF NOT EXISTS(SELECT * FROM [dbo].[VENPY_EntityTypes] WHERE [BUSI_Code] = @pintBUSI_Code AND [ETYP_Code] = 4 AND [ETYP_Name] = N'CAJEROS' )
	BEGIN 
		INSERT INTO [dbo].[VENPY_EntityTypes] ( BUSI_Code , ETYP_Code , ETYP_Name , ETYP_Description , ETYP_Active , ETYP_Default , AUDI_CreationUser , AUDI_CreationDate , AUDI_ModificationUser , AUDI_ModificationDate )
			VALUES  ( @pintBUSI_Code , 4 , N'CAJEROS' , N'PERSONAS RESPONSABLES DE SUMAR, CARGAR Y RECOGER EL PAGO POR LAS MERCANCÍAS O SERVICIOS PROPORCIONADOS' , 1 , 1 , N'SISTEMAS' , GETDATE() , NULL , NULL )
	END

IF NOT EXISTS(SELECT * FROM [dbo].[VENPY_EntityTypes] WHERE [BUSI_Code] = @pintBUSI_Code AND [ETYP_Code] = 5 AND [ETYP_Name] = N'ASESORES DE VENTAS' )
	BEGIN 
		INSERT INTO [dbo].[VENPY_EntityTypes] ( BUSI_Code , ETYP_Code , ETYP_Name , ETYP_Description , ETYP_Active , ETYP_Default , AUDI_CreationUser , AUDI_CreationDate , AUDI_ModificationUser , AUDI_ModificationDate )
			VALUES  ( @pintBUSI_Code , 5 , N'ASESORES DE VENTAS' , N'PERSONAS RESPONSABLES DE ASEGURARSE DE QUE LOS CLIENTES VIVAN UNA EXPERIENCIA DE COMPRAS INCREÍBLE' , 1 , 1 , N'SISTEMAS' , GETDATE() , NULL , NULL )
	END 