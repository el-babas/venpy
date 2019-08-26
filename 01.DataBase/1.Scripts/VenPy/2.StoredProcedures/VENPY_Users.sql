IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[USERS_Authentication]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[USERS_Authentication]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : Procedure for Authentication
-- =========================================================
CREATE PROCEDURE [dbo].[USERS_Authentication]
(	 
	 @pvchUSER_UserId		VARCHAR(20)
	,@pvchUSER_Password		VARCHAR(20)	 
) 
AS
BEGIN

	SELECT SUSE.USER_Code		, SUSE.USER_UserId		, SUSE.USER_Password	, SUSE.USER_UserName
		 , SUSE.USER_LastName	, SUSE.USER_Description	, SUSE.USER_Active		, SUSE.USER_Mail
		 , SUSE.GROU_Code
		 , SUSE.USER_LastName + ', ' + SUSE.USER_UserName AS USER_FullName
		 , GROU.GROU_Type AS USER_Type
	FROM dbo.VENPY_Users AS SUSE
	INNER JOIN dbo.VENPY_Groups AS GROU ON GROU.GROU_Code = SUSE.GROU_Code
	WHERE 
	SUSE.USER_Active = 1 AND
	SUSE.USER_UserId = @pvchUSER_UserId AND 
	SUSE.USER_Password = @pvchUSER_Password

END
GO