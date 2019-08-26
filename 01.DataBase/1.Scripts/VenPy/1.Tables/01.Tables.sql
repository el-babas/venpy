USE VenPy
GO 

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[VENPY_Ubigeos]' ) AND type in (N'U'))
	BEGIN
		CREATE TABLE [dbo].[VENPY_Ubigeos]
		(
			UBIG_Code				VARCHAR(20)		NOT NULL,
			UBIG_ParentCode			VARCHAR(20)		NULL,
			UBIG_SunatCode			VARCHAR(20)		NULL,
			UBIG_InternationalCode	VARCHAR(20)		NULL,
			UBIG_Description		VARCHAR(100)	NOT NULL,
			UBIG_Observations		VARCHAR(250)	NULL,
			AUDI_CreationUser		VARCHAR(20)		NOT NULL,
			AUDI_CreationDate		DATETIME		NOT NULL,
			AUDI_ModificationUser	VARCHAR(20)		NULL,
			AUDI_ModificationDate	DATETIME		NULL
		);

		ALTER TABLE dbo.VENPY_Ubigeos 
			ADD CONSTRAINT VENPY_Ubigeos_PK PRIMARY KEY CLUSTERED (UBIG_Code);

		ALTER TABLE dbo.VENPY_Ubigeos
			ADD CONSTRAINT VENPY_Ubigeos_FK_Ubigeos FOREIGN KEY (UBIG_ParentCode)
			REFERENCES dbo.VENPY_Ubigeos (UBIG_Code);
			
	END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[VENPY_Business]' ) AND type in (N'U'))
	BEGIN
		CREATE TABLE VENPY_Business
		(
			BUSI_Code				INT 			NOT NULL ,
			BUSI_RUC				VARCHAR(11)		NOT NULL ,
			BUSI_BusinessName		VARCHAR(100)	NOT NULL ,
			BUSI_TradeName			VARCHAR(100)	NULL ,
			BUSI_Address1			VARCHAR(100)	NOT NULL ,
			BUSI_Address2			VARCHAR(100)	NULL ,
			BUSI_Urbanization		VARCHAR(50)		NULL ,
			BUSI_Email				VARCHAR(150)	NULL ,	
			BUSI_Web				VARCHAR(100)	NULL ,
			BUSI_SocialNetworks		VARCHAR(250)	NULL ,
			BUSI_PhoneNumber1		VARCHAR(25)		NULL ,
			BUSI_PhoneNumber2		VARCHAR(25)		NULL ,
			BUSI_BankAccount		VARCHAR(20)		NULL ,
			UBIG_Code				VARCHAR(20)		NOT NULL,
			AUDI_CreationUser		VARCHAR(20)		NOT NULL,
			AUDI_CreationDate		DATETIME		NOT NULL,
			AUDI_ModificationUser	VARCHAR(20)		NULL,
			AUDI_ModificationDate	DATETIME		NULL
		);

		ALTER TABLE VENPY_Business 
			ADD CONSTRAINT VENPY_Business_PK PRIMARY KEY CLUSTERED (BUSI_Code);

		ALTER TABLE	VENPY_Business
			ADD CONSTRAINT VENPY_Business_FK_Ubigeos FOREIGN KEY (UBIG_Code) 
		    REFERENCES dbo.VENPY_Ubigeos (UBIG_Code);

		ALTER TABLE VENPY_Business 
			ADD CONSTRAINT VENPY_Business_UK_RUC UNIQUE (BUSI_RUC);   
	END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[VENPY_Tables]' ) AND type in (N'U'))
	BEGIN
		CREATE TABLE VENPY_Tables 
		(
			BUSI_Code				INT 			NOT NULL ,
			TBLE_Table				VARCHAR(3) 		NOT NULL ,
		    TBLE_Code				VARCHAR(6) 		NOT NULL ,
			TBLE_InternationalCode	VARCHAR(5)		NULL ,
			TBLE_SunatCode			VARCHAR(20)		NULL,
			TBLE_Description1		VARCHAR(200)	NOT NULL ,
			TBLE_Description2		VARCHAR(150)	NULL ,
			TBLE_Number1			INT 			NULL ,
			TBLE_Number2			DECIMAL(12,2)   NULL ,
			TBLE_Status				CHAR(1)			NOT NULL ,
			TBLE_Default			BIT				NOT NULL ,
			AUDI_CreationUser		VARCHAR(20)		NOT NULL,
			AUDI_CreationDate		DATETIME		NOT NULL,
			AUDI_ModificationUser	VARCHAR(20)		NULL,
			AUDI_ModificationDate	DATETIME		NULL
		);

		ALTER TABLE VENPY_Tables 
			ADD CONSTRAINT VENPY_Tables_PK PRIMARY KEY CLUSTERED (BUSI_Code, TBLE_Table, TBLE_Code);

		ALTER TABLE	VENPY_Tables
				ADD CONSTRAINT VENPY_Tables_FK_Business FOREIGN KEY (BUSI_Code) 
			    REFERENCES dbo.VENPY_Business (BUSI_Code);
	END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[VENPY_BranchOffices]' ) AND type in (N'U'))
	BEGIN
		CREATE TABLE VENPY_BranchOffices
		(
			BUSI_Code				INT 			NOT NULL ,
		    BOFF_Code				INT 			NOT NULL ,
			BOFF_Name				VARCHAR(100)	NOT NULL ,
			BOFF_Address			VARCHAR(100)	NOT NULL ,
		    BOFF_Description		VARCHAR(250)	NULL ,
			BOFF_Email				VARCHAR(150)	NULL ,	
			BOFF_Web				VARCHAR(100)	NULL ,
			BOFF_SocialNetworks		VARCHAR(250)	NULL ,
			BOFF_PhoneNumber1		VARCHAR(25)		NULL ,
			BOFF_PhoneNumber2		VARCHAR(25)		NULL ,
			UBIG_Code				VARCHAR(20)		NOT NULL,
			AUDI_CreationUser		VARCHAR(20)		NOT NULL,
			AUDI_CreationDate		DATETIME		NOT NULL,
			AUDI_ModificationUser	VARCHAR(20)		NULL,
			AUDI_ModificationDate	DATETIME		NULL
		);
		
		ALTER TABLE VENPY_BranchOffices 
			ADD CONSTRAINT VENPY_BranchOffices_PK PRIMARY KEY CLUSTERED (BUSI_Code, BOFF_Code);
		
		ALTER TABLE	VENPY_BranchOffices
			ADD CONSTRAINT VENPY_BranchOffices_FK_Business FOREIGN KEY (BUSI_Code) 
		    REFERENCES dbo.VENPY_Business (BUSI_Code);
		    
		ALTER TABLE	VENPY_BranchOffices
			ADD CONSTRAINT VENPY_BranchOffices_FK_Ubigeos FOREIGN KEY (UBIG_Code) 
		    REFERENCES dbo.VENPY_Ubigeos (UBIG_Code);
	END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[VENPY_PointsSale]' ) AND type in (N'U'))
	BEGIN
		CREATE TABLE VENPY_PointsSale
		(
			BUSI_Code				INT 			NOT NULL ,
		    BOFF_Code				INT 			NOT NULL ,
			PSAL_Code				INT 			NOT NULL ,	
			PSAL_Name				VARCHAR(100)	NOT NULL ,
			PSAL_Main				BIT				NOT NULL ,	
			PSAL_Status				CHAR(1)			NOT NULL ,
            AUDI_CreationUser		VARCHAR(20)		NOT NULL ,
			AUDI_CreationDate		DATETIME		NOT NULL ,
			AUDI_ModificationUser	VARCHAR(20)		NULL ,
			AUDI_ModificationDate	DATETIME		NULL
		);

		ALTER TABLE VENPY_PointsSale 
			ADD CONSTRAINT VENPY_PointsSale_PK PRIMARY KEY CLUSTERED (BUSI_Code, BOFF_Code, PSAL_Code);
		
		ALTER TABLE	VENPY_PointsSale
			ADD CONSTRAINT VENPY_PointsSale_FK_BranchOffices FOREIGN KEY (BUSI_Code, BOFF_Code) 
		    REFERENCES dbo.VENPY_BranchOffices(BUSI_Code, BOFF_Code);
	END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[VENPY_EntityTypes]' ) AND type in (N'U'))
	BEGIN
		CREATE TABLE VENPY_EntityTypes
		(
			BUSI_Code				INT 			NOT NULL ,
			ETYP_Code				INT				NOT NULL ,
			ETYP_Name				VARCHAR(100)	NOT NULL ,
			ETYP_Description		VARCHAR(150)	NULL ,
			ETYP_Active				BIT				NOT NULL ,
			ETYP_Default			BIT				NOT NULL ,
			AUDI_CreationUser		VARCHAR(20)		NOT NULL ,
			AUDI_CreationDate		DATETIME		NOT NULL ,
			AUDI_ModificationUser	VARCHAR(20)		NULL ,
			AUDI_ModificationDate	DATETIME		NULL
		);

		ALTER TABLE VENPY_EntityTypes
			ADD CONSTRAINT VENPY_EntityTypes_PK PRIMARY KEY CLUSTERED (BUSI_Code, ETYP_Code);

		ALTER TABLE dbo.VENPY_EntityTypes
			ADD CONSTRAINT VENPY_EntityTypes_FK_Business FOREIGN KEY (BUSI_Code)
			REFERENCES dbo.VENPY_Business (BUSI_Code);
	END
GO 

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[VENPY_Entities]' ) AND type in (N'U'))
	BEGIN
		CREATE TABLE VENPY_Entities
		(
			BUSI_Code				INT 			NOT NULL ,
			ENTI_Code				INT				NOT NULL ,
			TBLE_TableTDI			VARCHAR(3) 		NOT NULL ,
		    TBLE_CodeTDI			VARCHAR(6) 		NOT NULL ,
			ENTI_EntityType			CHAR(1)			NOT NULL ,
			ENTI_DocumentNumber		VARCHAR(20)		NOT NULL ,
			ENTI_BusinessName		VARCHAR(100)	NOT NULL ,
			ENTI_Birthdate			DATE			NULL ,
			ENTI_Address			VARCHAR(200)	NOT NULL ,
			UBIG_Code				VARCHAR(20)		NULL ,
			ENTI_Email				VARCHAR(150)	NULL ,	
			ENTI_Web				VARCHAR(100)	NULL ,
			ENTI_PhoneNumber		VARCHAR(50)		NULL ,
			ENTI_ReferentialAddress VARCHAR(100)	NULL ,
			ENTI_Domiciled			BIT				NOT NULL ,
			TBLE_TablePAI			VARCHAR(3) 		NULL ,
		    TBLE_CodePAI			VARCHAR(6) 		NULL ,
			ENTI_Favourite			BIT				NOT NULL ,
			ENTI_BankAccount		VARCHAR(20)		NULL ,
			ENTI_Status				CHAR(1)			NOT NULL ,
			AUDI_CreationUser		VARCHAR(20)		NOT NULL ,
			AUDI_CreationDate		DATETIME		NOT NULL ,
			AUDI_ModificationUser	VARCHAR(20)		NULL ,
			AUDI_ModificationDate	DATETIME		NULL
		);

		ALTER TABLE VENPY_Entities
			ADD CONSTRAINT VENPY_Entities_PK PRIMARY KEY CLUSTERED (BUSI_Code, ENTI_Code);

		ALTER TABLE dbo.VENPY_Entities
			ADD CONSTRAINT VENPY_Entities_FK_Business FOREIGN KEY (BUSI_Code)
			REFERENCES dbo.VENPY_Business (BUSI_Code);

		ALTER TABLE dbo.VENPY_Entities
			ADD CONSTRAINT VENPY_Entities_FK_Tables_TDI FOREIGN KEY (BUSI_Code, TBLE_TableTDI, TBLE_CodeTDI)
			REFERENCES dbo.VENPY_Tables (BUSI_Code, TBLE_Table, TBLE_Code);

		ALTER TABLE dbo.VENPY_Entities
			ADD CONSTRAINT VENPY_Entities_FK_Tables_PAI FOREIGN KEY (BUSI_Code, TBLE_TablePAI, TBLE_CodePAI)
			REFERENCES dbo.VENPY_Tables (BUSI_Code, TBLE_Table, TBLE_Code);

		ALTER TABLE	dbo.VENPY_Entities
			ADD CONSTRAINT VENPY_Entities_FK_Ubigeos FOREIGN KEY (UBIG_Code) 
		    REFERENCES dbo.VENPY_Ubigeos (UBIG_Code);
	END 
GO 	

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[VENPY_FunctionsEntities]' ) AND type in (N'U'))
	BEGIN
		CREATE TABLE VENPY_FunctionsEntities
		(
			BUSI_Code				INT 			NOT NULL ,
			ENTI_Code				INT				NOT NULL ,
			ETYP_Code				INT				NOT NULL ,
			AUDI_CreationUser		VARCHAR(20)		NOT NULL ,
			AUDI_CreationDate		DATETIME		NOT NULL ,
			AUDI_ModificationUser	VARCHAR(20)		NULL ,
			AUDI_ModificationDate	DATETIME		NULL
		);

		ALTER TABLE dbo.VENPY_FunctionsEntities
			ADD CONSTRAINT VENPY_FunctionsEntities_PK PRIMARY KEY CLUSTERED (BUSI_Code, ENTI_Code, ETYP_Code);

		ALTER TABLE dbo.VENPY_FunctionsEntities
			ADD CONSTRAINT VENPY_FunctionsEntities_FK_Entities FOREIGN KEY (BUSI_Code ,ENTI_Code)
			REFERENCES dbo.VENPY_Entities (BUSI_Code ,ENTI_Code);

		ALTER TABLE dbo.VENPY_FunctionsEntities
			ADD CONSTRAINT VENPY_FunctionsEntities_FK_EntityTypes FOREIGN KEY (BUSI_Code , ETYP_Code)
			REFERENCES dbo.VENPY_EntityTypes (BUSI_Code , ETYP_Code);
	END 
GO 

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[VENPY_WarehousesBranches]' ) AND type in (N'U'))
	BEGIN
		CREATE TABLE VENPY_WarehousesBranches
		(
			BUSI_Code				INT 			NOT NULL ,
			BOFF_Code				INT 			NOT NULL ,
			TBLE_TableALM			VARCHAR(3) 		NOT NULL ,
		    TBLE_CodeALM			VARCHAR(6) 		NOT NULL ,
			AUDI_CreationUser		VARCHAR(20)		NOT NULL ,
			AUDI_CreationDate		DATETIME		NOT NULL ,
			AUDI_ModificationUser	VARCHAR(20)		NULL ,
			AUDI_ModificationDate	DATETIME		NULL
		);

		ALTER TABLE dbo.VENPY_WarehousesBranches
			ADD CONSTRAINT VENPY_WarehousesBranches_PK PRIMARY KEY CLUSTERED (BUSI_Code, BOFF_Code, TBLE_TableALM, TBLE_CodeALM);

		ALTER TABLE dbo.VENPY_WarehousesBranches
			ADD CONSTRAINT VENPY_WarehousesBranches_FK_BranchOffices FOREIGN KEY (BUSI_Code ,BOFF_Code)
			REFERENCES dbo.VENPY_BranchOffices (BUSI_Code ,BOFF_Code);

		ALTER TABLE dbo.VENPY_WarehousesBranches
			ADD CONSTRAINT VENPY_WarehousesBranches_FK_Tables_ALM FOREIGN KEY (BUSI_Code, TBLE_TableALM, TBLE_CodeALM)
			REFERENCES dbo.VENPY_Tables (BUSI_Code, TBLE_Table, TBLE_Code);
	END 
GO 

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[VENPY_Products]' ) AND type in (N'U'))
	BEGIN
		CREATE TABLE VENPY_Products
		(
			BUSI_Code				INT 			NOT NULL ,
			PROD_Code				INT 			NOT NULL ,
			PROD_Active				BIT				NOT NULL ,
			TBLE_TableFAP			VARCHAR(3) 		NOT NULL ,
		    TBLE_CodeFAP			VARCHAR(6) 		NOT NULL ,
			TBLE_TableUNM			VARCHAR(3) 		NOT NULL ,
		    TBLE_CodeUNM			VARCHAR(6) 		NOT NULL ,
			PROD_Name				VARCHAR(50)		NOT NULL ,
			PROD_Description		VARCHAR(100)	NULL ,
			PROD_Original			BIT				NOT NULL ,
			TBLE_TableMAR			VARCHAR(3) 		NULL ,
		    TBLE_CodeMAR			VARCHAR(6) 		NULL ,
			PROD_Model				VARCHAR(50)		NULL ,
			PROD_Serie				VARCHAR(50)		NULL ,
			AUDI_CreationUser		VARCHAR(20)		NOT NULL ,
			AUDI_CreationDate		DATETIME		NOT NULL ,
			AUDI_ModificationUser	VARCHAR(20)		NULL ,
			AUDI_ModificationDate	DATETIME		NULL
		);

		ALTER TABLE dbo.VENPY_Products
			ADD CONSTRAINT VENPY_Products_PK PRIMARY KEY CLUSTERED (BUSI_Code, PROD_Code);

		ALTER TABLE dbo.VENPY_Products
			ADD CONSTRAINT VENPY_Products_FK_Business FOREIGN KEY (BUSI_Code)
			REFERENCES dbo.VENPY_Business (BUSI_Code);
		
		ALTER TABLE dbo.VENPY_Products
			ADD CONSTRAINT VENPY_Products_FK_Tables_FAP FOREIGN KEY (BUSI_Code, TBLE_TableFAP, TBLE_CodeFAP)
			REFERENCES dbo.VENPY_Tables (BUSI_Code, TBLE_Table, TBLE_Code);

		ALTER TABLE dbo.VENPY_Products
			ADD CONSTRAINT VENPY_Products_FK_Tables_UNM FOREIGN KEY (BUSI_Code, TBLE_TableUNM, TBLE_CodeUNM)
			REFERENCES dbo.VENPY_Tables (BUSI_Code, TBLE_Table, TBLE_Code);

		ALTER TABLE dbo.VENPY_Products
			ADD CONSTRAINT VENPY_Products_FK_Tables_MAR FOREIGN KEY (BUSI_Code, TBLE_TableMAR, TBLE_CodeMAR)
			REFERENCES dbo.VENPY_Tables (BUSI_Code, TBLE_Table, TBLE_Code);
	END 
GO 

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[VENPY_MeasurementUnitsProducts]' ) AND type in (N'U'))
	BEGIN
		CREATE TABLE VENPY_MeasurementUnitsProducts
		(
			BUSI_Code				INT 			NOT NULL ,
			PROD_Code				INT 			NOT NULL ,
			TBLE_TableUNM			VARCHAR(3) 		NOT NULL ,
		    TBLE_CodeUNM			VARCHAR(6) 		NOT NULL ,
			MUPR_ConversionFactor	DECIMAL(12,5)	NOT NULL ,
			AUDI_CreationUser		VARCHAR(20)		NOT NULL ,
			AUDI_CreationDate		DATETIME		NOT NULL ,
			AUDI_ModificationUser	VARCHAR(20)		NULL ,
			AUDI_ModificationDate	DATETIME		NULL
		);

		ALTER TABLE dbo.VENPY_MeasurementUnitsProducts
			ADD CONSTRAINT VENPY_MeasurementUnitsProducts_PK PRIMARY KEY CLUSTERED (BUSI_Code, PROD_Code, TBLE_TableUNM, TBLE_CodeUNM);

		ALTER TABLE dbo.VENPY_MeasurementUnitsProducts
			ADD CONSTRAINT VENPY_MeasurementUnitsProducts_FK_Products FOREIGN KEY (BUSI_Code ,PROD_Code)
			REFERENCES dbo.VENPY_Products (BUSI_Code ,PROD_Code);

		ALTER TABLE dbo.VENPY_MeasurementUnitsProducts
			ADD CONSTRAINT VENPY_MeasurementUnitsProducts_FK_Tables_UNM FOREIGN KEY (BUSI_Code, TBLE_TableUNM, TBLE_CodeUNM)
			REFERENCES dbo.VENPY_Tables (BUSI_Code, TBLE_Table, TBLE_Code);
	END 
GO 

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[VENPY_PriceList]' ) AND type in (N'U'))
	BEGIN
		CREATE TABLE VENPY_PriceList
		(
			BUSI_Code				INT 			NOT NULL ,
			PRLI_Code				INT 			NOT NULL ,
			PRLI_Active				BIT				NOT NULL ,
			TBLE_TableMND			VARCHAR(3) 		NOT NULL ,
		    TBLE_CodeMND			VARCHAR(6) 		NOT NULL ,
			PRLI_Name				VARCHAR(50)		NOT NULL ,
			TBLE_TableTAI			VARCHAR(3) 		NULL ,
		    TBLE_CodeTAI			VARCHAR(6) 		NULL ,
			PRLI_Description		VARCHAR(100)	NULL ,
			AUDI_CreationUser		VARCHAR(20)		NOT NULL ,
			AUDI_CreationDate		DATETIME		NOT NULL ,
			AUDI_ModificationUser	VARCHAR(20)		NULL ,
			AUDI_ModificationDate	DATETIME		NULL
		);

		ALTER TABLE dbo.VENPY_PriceList
			ADD CONSTRAINT VENPY_PriceList_PK PRIMARY KEY CLUSTERED (BUSI_Code, PRLI_Code);

		ALTER TABLE dbo.VENPY_PriceList
			ADD CONSTRAINT VENPY_PriceList_FK_Business FOREIGN KEY (BUSI_Code)
			REFERENCES dbo.VENPY_Business (BUSI_Code);

		ALTER TABLE dbo.VENPY_PriceList
			ADD CONSTRAINT VENPY_PriceList_FK_Tables_MND FOREIGN KEY (BUSI_Code, TBLE_TableMND, TBLE_CodeMND)
			REFERENCES dbo.VENPY_Tables (BUSI_Code, TBLE_Table, TBLE_Code);

		ALTER TABLE dbo.VENPY_PriceList
			ADD CONSTRAINT VENPY_PriceList_FK_Tables_TAI FOREIGN KEY (BUSI_Code, TBLE_TableTAI, TBLE_CodeTAI)
			REFERENCES dbo.VENPY_Tables (BUSI_Code, TBLE_Table, TBLE_Code);
	END 
GO 

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[VENPY_PriceListDetail]' ) AND type in (N'U'))
	BEGIN
		CREATE TABLE VENPY_PriceListDetail
		(
			BUSI_Code				INT 			NOT NULL ,
			PRLI_Code				INT 			NOT NULL ,
			PLDE_Item				INT				NOT NULL ,
			PROD_Code				INT 			NOT NULL ,
			TBLE_TableUNM			VARCHAR(3) 		NOT NULL ,
		    TBLE_CodeUNM			VARCHAR(6) 		NOT NULL ,
			TBLE_TableTAI			VARCHAR(3) 		NOT NULL ,
		    TBLE_CodeTAI			VARCHAR(6) 		NOT NULL ,
			PLDE_UnitValue			DECIMAL(20,8)	NOT NULL ,
			PLDE_IGV				DECIMAL(20,8)	NOT NULL ,
			PLDE_UnitPrice			DECIMAL(20,8)	NOT NULL ,
			AUDI_CreationUser		VARCHAR(20)		NOT NULL ,
			AUDI_CreationDate		DATETIME		NOT NULL ,
			AUDI_ModificationUser	VARCHAR(20)		NULL ,
			AUDI_ModificationDate	DATETIME		NULL
		);

		ALTER TABLE dbo.VENPY_PriceListDetail
			ADD CONSTRAINT VENPY_PriceListDetail_PK PRIMARY KEY CLUSTERED (BUSI_Code, PRLI_Code, PLDE_Item);

		ALTER TABLE dbo.VENPY_PriceListDetail
			ADD CONSTRAINT VENPY_PriceListDetail_FK_PriceList FOREIGN KEY (BUSI_Code, PRLI_Code)
			REFERENCES dbo.VENPY_PriceList (BUSI_Code, PRLI_Code);

		ALTER TABLE dbo.VENPY_PriceListDetail
			ADD CONSTRAINT VENPY_PriceListDetail_FK_Products FOREIGN KEY (BUSI_Code ,PROD_Code)
			REFERENCES dbo.VENPY_Products (BUSI_Code ,PROD_Code);

		ALTER TABLE dbo.VENPY_PriceListDetail
			ADD CONSTRAINT VENPY_PriceListDetail_FK_Tables_UNM FOREIGN KEY (BUSI_Code, TBLE_TableUNM, TBLE_CodeUNM)
			REFERENCES dbo.VENPY_Tables (BUSI_Code, TBLE_Table, TBLE_Code);

		ALTER TABLE dbo.VENPY_PriceListDetail
			ADD CONSTRAINT VENPY_PriceListDetail_FK_Tables_TAI FOREIGN KEY (BUSI_Code, TBLE_TableTAI, TBLE_CodeTAI)
			REFERENCES dbo.VENPY_Tables (BUSI_Code, TBLE_Table, TBLE_Code);
	END 
GO 

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[VENPY_Services]' ) AND type in (N'U'))
	BEGIN
		CREATE TABLE VENPY_Services
		(
			BUSI_Code				INT 			NOT NULL ,
			SERV_Code				INT 			NOT NULL ,
			SERV_Active				BIT				NOT NULL ,
			SERV_Name				VARCHAR(50)		NOT NULL ,
			SERV_Description		VARCHAR(100)	NULL ,
			TBLE_TableFAS			VARCHAR(3) 		NOT NULL ,
		    TBLE_CodeFAS			VARCHAR(6) 		NOT NULL ,
			TBLE_TableUNM			VARCHAR(3) 		NOT NULL ,
		    TBLE_CodeUNM			VARCHAR(6) 		NOT NULL ,
			TBLE_TableTAI			VARCHAR(3) 		NOT NULL ,
		    TBLE_CodeTAI			VARCHAR(6) 		NOT NULL ,
			TBLE_TableMND			VARCHAR(3) 		NOT NULL ,
		    TBLE_CodeMND			VARCHAR(6) 		NOT NULL ,
			SERV_UnitValue			DECIMAL(20,8)	NOT NULL ,
			SERV_IGV				DECIMAL(20,8)	NOT NULL ,
			SERV_UnitPrice			DECIMAL(20,8)	NOT NULL ,
			AUDI_CreationUser		VARCHAR(20)		NOT NULL ,
			AUDI_CreationDate		DATETIME		NOT NULL ,
			AUDI_ModificationUser	VARCHAR(20)		NULL ,
			AUDI_ModificationDate	DATETIME		NULL
		);

		ALTER TABLE dbo.VENPY_Services
			ADD CONSTRAINT VENPY_Services_PK PRIMARY KEY CLUSTERED (BUSI_Code, SERV_Code);

		ALTER TABLE dbo.VENPY_Services
			ADD CONSTRAINT VENPY_Services_FK_Business FOREIGN KEY (BUSI_Code)
			REFERENCES dbo.VENPY_Business (BUSI_Code);
		
		ALTER TABLE dbo.VENPY_Services
			ADD CONSTRAINT VENPY_Services_FK_Tables_FAS FOREIGN KEY (BUSI_Code, TBLE_TableFAS, TBLE_CodeFAS)
			REFERENCES dbo.VENPY_Tables (BUSI_Code, TBLE_Table, TBLE_Code);

		ALTER TABLE dbo.VENPY_Services
			ADD CONSTRAINT VENPY_Services_FK_Tables_UNM FOREIGN KEY (BUSI_Code, TBLE_TableUNM, TBLE_CodeUNM)
			REFERENCES dbo.VENPY_Tables (BUSI_Code, TBLE_Table, TBLE_Code);

		ALTER TABLE dbo.VENPY_Services
			ADD CONSTRAINT VENPY_Services_FK_Tables_TAI FOREIGN KEY (BUSI_Code, TBLE_TableTAI, TBLE_CodeTAI)
			REFERENCES dbo.VENPY_Tables (BUSI_Code, TBLE_Table, TBLE_Code);

		ALTER TABLE dbo.VENPY_Services
			ADD CONSTRAINT VENPY_Services_FK_Tables_MND FOREIGN KEY (BUSI_Code, TBLE_TableMND, TBLE_CodeMND)
			REFERENCES dbo.VENPY_Tables (BUSI_Code, TBLE_Table, TBLE_Code);
		
	END 
GO 

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[VENPY_ExchangeRate]' ) AND type in (N'U'))
	BEGIN
		CREATE TABLE VENPY_ExchangeRate
		(
			BUSI_Code				INT 			NOT NULL ,
			EXRA_Date				DATE			NOT NULL ,
			EXRA_OfficialPurchase	DECIMAL(10,3)	NOT NULL ,
			EXRA_OfficialSale		DECIMAL(10,3)	NOT NULL ,
			EXRA_InternalPurchase	DECIMAL(10,3)	NOT NULL ,
			EXRA_InternalSale		DECIMAL(10,3)	NOT NULL ,
			AUDI_CreationUser		VARCHAR(20)		NOT NULL ,
			AUDI_CreationDate		DATETIME		NOT NULL ,
			AUDI_ModificationUser	VARCHAR(20)		NULL ,
			AUDI_ModificationDate	DATETIME		NULL
		);

		ALTER TABLE dbo.VENPY_ExchangeRate
			ADD CONSTRAINT VENPY_ExchangeRate_PK PRIMARY KEY CLUSTERED (BUSI_Code, EXRA_Date);

		ALTER TABLE dbo.VENPY_ExchangeRate
			ADD CONSTRAINT VENPY_ExchangeRate_FK_Business FOREIGN KEY (BUSI_Code)
			REFERENCES dbo.VENPY_Business (BUSI_Code);
	END
GO 

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[VENPY_Series]' ) AND type in (N'U'))
	BEGIN
		CREATE TABLE VENPY_Series
		(
			BUSI_Code				INT 			NOT NULL ,
			SERI_Code				INT 			NOT NULL ,
			TBLE_TableTDO			VARCHAR(3) 		NOT NULL ,
		    TBLE_CodeTDO			VARCHAR(6) 		NOT NULL ,
			SERI_Serie				CHAR(4)			NOT NULL ,
			SERI_Number				INT				NOT NULL ,
			SERI_Description		VARCHAR(100)	NULL ,
			AUDI_CreationUser		VARCHAR(20)		NOT NULL ,
			AUDI_CreationDate		DATETIME		NOT NULL ,
			AUDI_ModificationUser	VARCHAR(20)		NULL ,
			AUDI_ModificationDate	DATETIME		NULL
		);

		ALTER TABLE dbo.VENPY_Series
			ADD CONSTRAINT VENPY_Series_PK PRIMARY KEY CLUSTERED (BUSI_Code, SERI_Code);

		ALTER TABLE dbo.VENPY_Series
			ADD CONSTRAINT VENPY_Series_UK UNIQUE (BUSI_Code,TBLE_TableTDO,TBLE_CodeTDO,SERI_Serie);

		ALTER TABLE dbo.VENPY_Series
			ADD CONSTRAINT VENPY_Series_FK_Business FOREIGN KEY (BUSI_Code)
			REFERENCES dbo.VENPY_Business (BUSI_Code);
		
		ALTER TABLE dbo.VENPY_Series
			ADD CONSTRAINT VENPY_Series_FK_Tables_TDO FOREIGN KEY (BUSI_Code, TBLE_TableTDO, TBLE_CodeTDO)
			REFERENCES dbo.VENPY_Tables (BUSI_Code, TBLE_Table, TBLE_Code);
		
	END 
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[VENPY_Proformas]' ) AND type in (N'U'))
	BEGIN
		CREATE TABLE VENPY_Proformas
		(
			BUSI_Code				INT 			NOT NULL ,
			PROF_Code				INT				NOT NULL ,
			ENTI_Code				INT				NOT NULL ,
			PROF_Number				VARCHAR(50)		NOT NULL ,
			PROF_Date				DATE			NOT NULL ,
			PROF_DueDate			DATE			NULL ,
			TBLE_TableMND			VARCHAR(3) 		NOT NULL ,
		    TBLE_CodeMND			VARCHAR(6) 		NOT NULL ,
			PRLI_Code				INT 			NULL ,
			PROF_Status				CHAR(1)			NOT NULL ,
			PROF_Export				BIT				NOT NULL ,
			PROF_IGV				DECIMAL(20,8)	NOT NULL ,
			PROF_PercentageIGV		DECIMAL(20,3)	NOT NULL ,
			PROF_ISC				DECIMAL(20,8)	NOT NULL ,
			PROF_Discount			DECIMAL(20,8)	NOT NULL ,
			PROF_TotalPrice			DECIMAL(20,8)	NOT NULL ,
			PROF_Generated			BIT				NOT NULL ,
			AUDI_CreationUser		VARCHAR(20)		NOT NULL ,
			AUDI_CreationDate		DATETIME		NOT NULL ,
			AUDI_ModificationUser	VARCHAR(20)		NULL ,
			AUDI_ModificationDate	DATETIME		NULL
		);

		ALTER TABLE dbo.VENPY_Proformas
			ADD CONSTRAINT VENPY_Proformas_PK PRIMARY KEY CLUSTERED (BUSI_Code, PROF_Code);

		ALTER TABLE dbo.VENPY_Proformas
			ADD CONSTRAINT VENPY_Proformas_FK_Business FOREIGN KEY (BUSI_Code)
			REFERENCES dbo.VENPY_Business (BUSI_Code);

		ALTER TABLE dbo.VENPY_Proformas
			ADD CONSTRAINT VENPY_Proformas_FK_Entities FOREIGN KEY (BUSI_Code, ENTI_Code)
			REFERENCES dbo.VENPY_Entities (BUSI_Code, ENTI_Code);

		ALTER TABLE dbo.VENPY_Proformas
			ADD CONSTRAINT VENPY_Proformas_FK_Tables_MND FOREIGN KEY (BUSI_Code, TBLE_TableMND, TBLE_CodeMND)
			REFERENCES dbo.VENPY_Tables (BUSI_Code, TBLE_Table, TBLE_Code);

		ALTER TABLE dbo.VENPY_Proformas
			ADD CONSTRAINT VENPY_Proformas_FK_PriceList FOREIGN KEY (BUSI_Code, PRLI_Code)
			REFERENCES dbo.VENPY_PriceList	(BUSI_Code, PRLI_Code);

	END 
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[VENPY_ProformaDetails]' ) AND type in (N'U'))
	BEGIN
		CREATE TABLE VENPY_ProformaDetails
		(
			BUSI_Code				INT 			NOT NULL ,
			PROF_Code				INT				NOT NULL ,
			PFDE_Item				INT				NOT NULL ,
			PFDE_Type				CHAR(1)			NOT NULL ,
			TBLE_TableFAP			VARCHAR(3) 		NULL ,
		    TBLE_CodeFAP			VARCHAR(6) 		NULL ,
			TBLE_TableFAS			VARCHAR(3) 		NULL ,
		    TBLE_CodeFAS			VARCHAR(6) 		NULL ,
			PROD_Code				INT 			NULL ,
			SERV_Code				INT 			NULL ,
			PLDE_Description		VARCHAR(200)	NOT NULL ,
			TBLE_TableUNM			VARCHAR(3) 		NOT NULL ,
		    TBLE_CodeUNM			VARCHAR(6) 		NOT NULL ,
			TBLE_TableTAI			VARCHAR(3) 		NOT NULL ,
		    TBLE_CodeTAI			VARCHAR(6) 		NOT NULL ,
			PLDE_UnitValue			DECIMAL(20,8)	NOT NULL ,
			PLDE_UnitPrice			DECIMAL(20,8)	NOT NULL ,
			PLDE_Quantity			DECIMAL(20,8)	NOT NULL ,
			PLDE_IGV				DECIMAL(20,8)	NOT NULL ,
			PLDE_ISC				DECIMAL(20,8)	NOT NULL ,
			PROF_Discount			DECIMAL(20,8)	NOT NULL ,
			AUDI_CreationUser		VARCHAR(20)		NOT NULL ,
			AUDI_CreationDate		DATETIME		NOT NULL ,
			AUDI_ModificationUser	VARCHAR(20)		NULL ,
			AUDI_ModificationDate	DATETIME		NULL
		);

		ALTER TABLE dbo.VENPY_ProformaDetails
			ADD CONSTRAINT VENPY_ProformaDetails_PK PRIMARY KEY CLUSTERED (BUSI_Code, PROF_Code, PFDE_Item);

		ALTER TABLE dbo.VENPY_ProformaDetails
			ADD CONSTRAINT VENPY_ProformaDetails_FK_Proformas FOREIGN KEY (BUSI_Code, PROF_Code)
			REFERENCES dbo.VENPY_Proformas (BUSI_Code, PROF_Code);

		ALTER TABLE dbo.VENPY_ProformaDetails
			ADD CONSTRAINT VENPY_ProformaDetails_FK_Tables_FAP FOREIGN KEY (BUSI_Code, TBLE_TableFAP, TBLE_CodeFAP)
			REFERENCES dbo.VENPY_Tables (BUSI_Code, TBLE_Table, TBLE_Code);

		ALTER TABLE dbo.VENPY_ProformaDetails
			ADD CONSTRAINT VENPY_ProformaDetails_FK_Tables_FAS FOREIGN KEY (BUSI_Code, TBLE_TableFAS, TBLE_CodeFAS)
			REFERENCES dbo.VENPY_Tables (BUSI_Code, TBLE_Table, TBLE_Code);

		ALTER TABLE dbo.VENPY_ProformaDetails
			ADD CONSTRAINT VENPY_ProformaDetails_FK_Products FOREIGN KEY (BUSI_Code, PROD_Code)
			REFERENCES dbo.VENPY_Products (BUSI_Code, PROD_Code)

		ALTER TABLE dbo.VENPY_ProformaDetails
			ADD CONSTRAINT VENPY_ProformaDetails_FK_Services FOREIGN KEY (BUSI_Code, SERV_Code)
			REFERENCES dbo.VENPY_Services (BUSI_Code, SERV_Code)

		ALTER TABLE dbo.VENPY_ProformaDetails
			ADD CONSTRAINT VENPY_ProformaDetails_FK_Tables_UNM FOREIGN KEY (BUSI_Code, TBLE_TableUNM, TBLE_CodeUNM)
			REFERENCES dbo.VENPY_Tables (BUSI_Code, TBLE_Table, TBLE_Code);

		ALTER TABLE dbo.VENPY_ProformaDetails
			ADD CONSTRAINT VENPY_ProformaDetails_FK_Tables_TAI FOREIGN KEY (BUSI_Code, TBLE_TableTAI, TBLE_CodeTAI)
			REFERENCES dbo.VENPY_Tables (BUSI_Code, TBLE_Table, TBLE_Code);

	END 
GO