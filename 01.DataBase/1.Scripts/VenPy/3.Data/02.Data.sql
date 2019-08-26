/********************************************************************************************************************/
/*********************************************** GROUPS *************************************************************/
/********************************************************************************************************************/

IF NOT EXISTS(SELECT * FROM [dbo].[VENPY_Groups] WHERE [GROU_Code] = 1 AND [GROU_Type] = 'R')
	BEGIN
		INSERT [dbo].[VENPY_Groups] ([GROU_Code], [GROU_Description1], [GROU_Description2], [GROU_Type], [AUDI_CreationUser], [AUDI_CreationDate], [AUDI_ModificationUser], [AUDI_ModificationDate]) 
			VALUES (1, N'SUPER USUARIO', N'SUPER USUARIO', N'R', N'SISTEMAS', GETDATE(), NULL, NULL)
	END 
GO
IF NOT EXISTS(SELECT * FROM [dbo].[VENPY_Groups] WHERE [GROU_Code] = 2 AND [GROU_Type] = 'A')
	BEGIN
		INSERT [dbo].[VENPY_Groups] ([GROU_Code], [GROU_Description1], [GROU_Description2], [GROU_Type], [AUDI_CreationUser], [AUDI_CreationDate], [AUDI_ModificationUser], [AUDI_ModificationDate]) 
			VALUES (2, N'ADMINISTRADOR', N'ADMINISTRADOR', N'A', N'SISTEMAS', GETDATE(), NULL, NULL)
	END
 GO
IF NOT EXISTS(SELECT * FROM [dbo].[VENPY_Groups] WHERE [GROU_Code] = 3 AND [GROU_Type] = 'N')
	BEGIN
		INSERT [dbo].[VENPY_Groups] ([GROU_Code], [GROU_Description1], [GROU_Description2], [GROU_Type], [AUDI_CreationUser], [AUDI_CreationDate], [AUDI_ModificationUser], [AUDI_ModificationDate]) 
			VALUES (3, N'USUARIO NORMAL', N'USUARIO NORMAL', N'N', N'SISTEMAS', GETDATE(), NULL, NULL)
	END
GO

/********************************************************************************************************************/
/************************************************** USERS ***********************************************************/
/********************************************************************************************************************/

IF NOT EXISTS(SELECT * FROM [dbo].[VENPY_Users] WHERE [USER_Code] = 1 AND  [GROU_Code] = 1 )
	BEGIN
		INSERT [dbo].[VENPY_Users] ([USER_Code], [USER_UserId], [USER_Password], [USER_UserName], [USER_LastName], [USER_Description], [USER_Active], [USER_Mail], [GROU_Code], [AUDI_CreationUser], [AUDI_CreationDate], [AUDI_ModificationUser], [AUDI_ModificationDate]) 
			VALUES (1, N'ROOT', N'U$%[', N'CRISTHIAN JOSE', N'APAZA ARHUATA', N'ROOT', 1, N'cristhian.cjaa@gmail.com', 1, N'SISTEMAS', GETDATE(), NULL, NULL)
	END 
GO

/********************************************************************************************************************/
/************************************************* PERMITS **********************************************************/
/********************************************************************************************************************/

DECLARE @pintBUSI_Code INT , @pintBOFF_Code INT , @pintPSAL_Code INT
	SET @pintBUSI_Code = 1 -- Code of Company
	SET @pintBOFF_Code = 1 -- Code of Branch Office
	SET @pintPSAL_Code = 1 -- Code of Point Sale

IF NOT EXISTS(SELECT * FROM [dbo].[VENPY_BranchOfficesUsers] WHERE [USER_Code] = 1 AND [BUSI_Code] = @pintBUSI_Code AND [BOFF_Code] = @pintBOFF_Code )
	BEGIN
		INSERT [dbo].[VENPY_BranchOfficesUsers] ([USER_Code], [BUSI_Code], [BOFF_Code]) 
			VALUES (1, @pintBUSI_Code, @pintBOFF_Code)
	END 

IF NOT EXISTS(SELECT * FROM [dbo].[VENPY_PointsSaleUsers] WHERE [USER_Code] = 1 AND [BUSI_Code] = @pintBUSI_Code AND [BOFF_Code] = @pintBOFF_Code AND [PSAL_Code] = @pintPSAL_Code)
	BEGIN
		INSERT [dbo].[VENPY_PointsSaleUsers] ([USER_Code], [BUSI_Code], [BOFF_Code], [PSAL_Code]) 
			VALUES (1, @pintBUSI_Code, @pintBOFF_Code, @pintPSAL_Code)
	END
    
