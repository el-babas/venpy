USE VenPy
GO 

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[VENPY_Groups]' ) AND type in (N'U'))
	BEGIN
		CREATE TABLE VENPY_Groups
		(
			GROU_Code				INT 			NOT NULL,
			GROU_Description1		VARCHAR(50)		NOT NULL,
			GROU_Description2		VARCHAR(100)	NULL,
			GROU_Type				CHAR(1)			NOT NULL,		
			AUDI_CreationUser		VARCHAR(20)		NOT NULL,
			AUDI_CreationDate		DATETIME		NOT NULL,
			AUDI_ModificationUser	VARCHAR(20)		NULL,
			AUDI_ModificationDate	DATETIME		NULL
		);

		ALTER TABLE VENPY_Groups 
			ADD CONSTRAINT VENPY_Groups_PK PRIMARY KEY CLUSTERED (GROU_Code);
	END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[VENPY_Users]' ) AND type in (N'U'))
	BEGIN
		CREATE TABLE VENPY_Users 
		(
			USER_Code				INT				NOT NULL,
			USER_UserId				VARCHAR(20)		NOT NULL,
			USER_Password			VARCHAR(20)		NOT NULL,
			USER_UserName			VARCHAR(100)	NOT NULL,
			USER_LastName			VARCHAR(100)	NOT NULL,
			USER_Description		VARCHAR(50)		NULL,
			USER_Active				BIT				NOT NULL,
			USER_Mail				VARCHAR(70)		NULL,
			GROU_Code				INT 			NOT NULL,
			AUDI_CreationUser		VARCHAR(20)		NOT NULL,
			AUDI_CreationDate		DATETIME		NOT NULL,
			AUDI_ModificationUser	VARCHAR(20)		NULL,
			AUDI_ModificationDate	DATETIME		NULL
		);

		ALTER TABLE VENPY_Users 
			ADD CONSTRAINT VENPY_Users_PK PRIMARY KEY CLUSTERED (USER_Code)

		ALTER TABLE	VENPY_Users
			ADD CONSTRAINT VENPY_Users_FK_Groups FOREIGN KEY (GROU_Code) 
			REFERENCES dbo.VENPY_Groups(GROU_Code);

		ALTER TABLE VENPY_Users 
				ADD CONSTRAINT VENPY_Users_UK_Id UNIQUE (USER_UserId);  
	END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[VENPY_BranchOfficesUsers]' ) AND type in (N'U'))
	BEGIN
		CREATE TABLE VENPY_BranchOfficesUsers
		(
			USER_Code		INT		NOT NULL,
			BUSI_Code		INT		NOT NULL,
		    BOFF_Code		INT		NOT NULL 
		);

		ALTER TABLE VENPY_BranchOfficesUsers 
			ADD CONSTRAINT VENPY_BranchOfficesUsers_PK PRIMARY KEY CLUSTERED (USER_Code,BUSI_Code,BOFF_Code)
		
		ALTER TABLE	VENPY_BranchOfficesUsers
			ADD CONSTRAINT VENPY_BranchOfficesUsers_FK_Users FOREIGN KEY (USER_Code) 
			REFERENCES dbo.VENPY_Users (USER_Code);

		ALTER TABLE	VENPY_BranchOfficesUsers
			ADD CONSTRAINT VENPY_BranchOfficesUsers_FK_BranchOffices FOREIGN KEY (BUSI_Code, BOFF_Code) 
			REFERENCES dbo.VENPY_BranchOffices (BUSI_Code, BOFF_Code);
	END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[VENPY_PointsSaleUsers]' ) AND type in (N'U'))
	BEGIN
		CREATE TABLE VENPY_PointsSaleUsers
		(
			USER_Code		INT		NOT NULL,
			BUSI_Code		INT		NOT NULL,
		    BOFF_Code		INT		NOT NULL,
			PSAL_Code		INT		NOT NULL 
		);

		ALTER TABLE VENPY_PointsSaleUsers 
			ADD CONSTRAINT VENPY_PointsSaleUsers_PK PRIMARY KEY CLUSTERED (USER_Code, BUSI_Code, BOFF_Code, PSAL_Code)
		
		ALTER TABLE	VENPY_PointsSaleUsers
			ADD CONSTRAINT VENPY_PointsSaleUsers_FK_Users FOREIGN KEY (USER_Code) 
			REFERENCES dbo.VENPY_Users (USER_Code);

		ALTER TABLE	VENPY_PointsSaleUsers
			ADD CONSTRAINT VENPY_PointsSaleUsers_FK_PointsSale FOREIGN KEY (BUSI_Code, BOFF_Code, PSAL_Code)
			REFERENCES dbo.VENPY_PointsSale (BUSI_Code, BOFF_Code, PSAL_Code);
	END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[VENPY_PersonalConfiguration]' ) AND type in (N'U'))
	BEGIN
		CREATE TABLE VENPY_PersonalConfiguration
		(
			BUSI_Code				INT				NOT NULL,
			USER_Code				INT				NOT NULL,
			PCON_Key				CHAR(4)			NOT NULL,
			PCON_Value				VARCHAR(50)		NOT NULL,
			PCON_Description		VARCHAR(100)	NOT NULL,
			AUDI_CreationUser		VARCHAR(20)		NOT NULL,
			AUDI_CreationDate		DATETIME		NOT NULL,
			AUDI_ModificationUser	VARCHAR(20)		NULL,
			AUDI_ModificationDate	DATETIME		NULL
		);

		ALTER TABLE VENPY_PersonalConfiguration 
			ADD CONSTRAINT VENPY_PersonalConfiguration_PK PRIMARY KEY CLUSTERED (BUSI_Code, USER_Code, PCON_Key)
		
		ALTER TABLE	VENPY_PersonalConfiguration
			ADD CONSTRAINT VENPY_PersonalConfiguration_FK_Business FOREIGN KEY (BUSI_Code) 
			REFERENCES dbo.VENPY_Business (BUSI_Code);

		ALTER TABLE	VENPY_PersonalConfiguration
			ADD CONSTRAINT VENPY_PersonalConfiguration_FK_Users FOREIGN KEY (USER_Code) 
			REFERENCES dbo.VENPY_Users (USER_Code);
	END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[VENPY_Settings]' ) AND type in (N'U'))
	BEGIN
		CREATE TABLE VENPY_Settings
		(
			BUSI_Code				INT				NOT NULL,
			SETT_Key				CHAR(4)			NOT NULL,
			SETT_Value				VARCHAR(50)		NOT NULL,
			SETT_Description		VARCHAR(100)	NOT NULL,
			AUDI_CreationUser		VARCHAR(20)		NOT NULL,
			AUDI_CreationDate		DATETIME		NOT NULL,
			AUDI_ModificationUser	VARCHAR(20)		NULL,
			AUDI_ModificationDate	DATETIME		NULL
		);

		ALTER TABLE VENPY_Settings 
			ADD CONSTRAINT VENPY_Settings_PK PRIMARY KEY CLUSTERED (BUSI_Code, SETT_Key)
		
		ALTER TABLE	VENPY_Settings
			ADD CONSTRAINT VENPY_Settings_FK_Business FOREIGN KEY (BUSI_Code) 
			REFERENCES dbo.VENPY_Business (BUSI_Code); 
	END
GO