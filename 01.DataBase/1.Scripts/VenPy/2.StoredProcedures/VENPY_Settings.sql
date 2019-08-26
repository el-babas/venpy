IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SETTS_ByBusiness]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[SETTS_ByBusiness]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[SETTS_ByBusiness]
(	 
	 @pintBUSI_Code		INT
) 
AS
BEGIN

	SELECT	 SETT.BUSI_Code		,SETT.SETT_Key 
			,SETT.SETT_Value	,SETT.SETT_Description 
	FROM [dbo].[VENPY_Settings] AS SETT
	WHERE [SETT].[BUSI_Code] = @pintBUSI_Code
	
END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SETTI_ASetting]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[SETTI_ASetting]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[SETTI_ASetting]
(
	 @pintBUSI_Code				INT 
	,@pchrSETT_Key				CHAR(4)
	,@pvchSETT_Value			VARCHAR(50)
	,@pvchSETT_Description		VARCHAR(100)
	,@pvchAUDI_CreationUser		VARCHAR(20)
) 
AS 
BEGIN

	INSERT INTO [VENPY_Settings]
		(BUSI_Code			,SETT_Key	,SETT_Value ,SETT_Description
        ,AUDI_CreationUser	,AUDI_CreationDate)	
	VALUES
        (@pintBUSI_Code			,@pchrSETT_Key ,@pvchSETT_Value ,@pvchSETT_Description
        ,@pvchAUDI_CreationUser ,GETDATE())

END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SETTU_ASetting]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[SETTU_ASetting]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[SETTU_ASetting]
(
	 @pintBUSI_Code				INT 
	,@pchrSETT_Key				CHAR(4)
	,@pvchSETT_Value			VARCHAR(50)
	,@pvchAUDI_ModificationUser	VARCHAR(20)
) 
AS 
BEGIN

	UPDATE [VENPY_Settings]
	   SET [SETT_Value] = @pvchSETT_Value
		 , [AUDI_ModificationUser] = @pvchAUDI_ModificationUser
		 , [AUDI_ModificationDate] = GETDATE()
		WHERE 
		[BUSI_Code] = @pintBUSI_Code AND
		[SETT_Key] = @pchrSETT_Key

END
GO
