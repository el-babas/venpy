IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PCONS_ByUser]') AND type in (N'P', N'PC'))
   DROP PROCEDURE [dbo].[PCONS_ByUser]
GO

-- =========================================================
-- Autor - Fecha Crea  : Cristhian J. Apaza Arhuata
-- Descripcion         : 
-- =========================================================
CREATE PROCEDURE [dbo].[PCONS_ByUser]
(	 
	 @pintBUSI_Code		INT
	,@pintUSER_Code		INT  
) 
AS
BEGIN

	SELECT 
		  PCON.BUSI_Code	, PCON.USER_Code	, PCON.PCON_Key
		, PCON.PCON_Value	, PCON.PCON_Description
	FROM 
	dbo.VENPY_PersonalConfiguration AS PCON
	WHERE 
	PCON.BUSI_Code = @pintBUSI_Code AND 
	PCON.USER_Code = @pintUSER_Code

END
GO