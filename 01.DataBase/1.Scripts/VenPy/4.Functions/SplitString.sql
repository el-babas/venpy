IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('[dbo].[SplitString]') AND type = 'TF') 
	DROP FUNCTION [dbo].[SplitString]
GO

CREATE FUNCTION [dbo].[SplitString]
(    
      @Input NVARCHAR(MAX),
      @Character CHAR(1)
)
RETURNS @Tabla TABLE (
      Item VARCHAR(20)
)
AS
BEGIN

	DECLARE @individual VARCHAR(20) = NULL

	WHILE LEN(@Input) > 0
	BEGIN
		 IF PATINDEX('%' + @Character + '%', @Input) > 0
		 BEGIN
			  SET @individual = SUBSTRING(@Input, 0, PATINDEX('%' + @Character + '%', @Input))
			  SET @Input = SUBSTRING(@Input, LEN(@individual + @Character) + 1, LEN(@Input))
			  INSERT INTO @Tabla VALUES(@individual)
		 END
		 ELSE
		 BEGIN
			  SET @individual = @Input
			  SET @Input = NULL
			  INSERT INTO @Tabla VALUES(@individual)
		 END
	END
	RETURN
END
GO
