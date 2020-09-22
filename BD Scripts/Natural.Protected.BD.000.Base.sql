use  AnimalSpawn
go
CREATE TABLE Country (
 Id INT NOT NULL IDENTITY(1,1),
 Name VARCHAR(100),
 Code VARCHAR(25),
 ISOCode VARCHAR(30),
 Region INT,
 CreateAt datetime,
 CreatedBy INT,
 UpdateAt datetime,
 UpdatedBy INT,
 Status BIT DEFAULT 1
);

ALTER TABLE Country ADD CONSTRAINT PK_Country PRIMARY KEY (Id);


CREATE TABLE Family (
 Id INT NOT NULL IDENTITY(1,1),
 CommonName VARCHAR(150),
 Code VARCHAR(15),
 CreateAt datetime,
 CreatedBy INT,
 UpdateAt datetime,
 UpdatedBy INT,
 Status BIT DEFAULT 1
);

ALTER TABLE Family ADD CONSTRAINT PK_Family PRIMARY KEY (Id);


CREATE TABLE Genus (
 Id INT NOT NULL IDENTITY(1,1),
 Name VARCHAR(150),
 Code VARCHAR(15),
 CreateAt datetime,
 CreatedBy INT,
 UpdateAt datetime,
 UpdateBy INT,
 Status BIT DEFAULT 1
);

ALTER TABLE Genus ADD CONSTRAINT PK_Genus PRIMARY KEY (Id);


CREATE TABLE ProtectedArea (
 Id INT NOT NULL IDENTITY(1,1),
 Name VARCHAR(200),
 Design INT,
 Type VARCHAR(100),
 Area DECIMAL(10,2),
 YearEnactment INT,
 CountryId INT NOT NULL,
 CreateAt datetime NOT NULL,
 CreatedBy INT,
 UpdateAt datetime,
 UpdatedBy INT,
 Status BIT DEFAULT 1
);

ALTER TABLE ProtectedArea ADD CONSTRAINT PK_ProtectedArea PRIMARY KEY (Id);


CREATE TABLE Researcher (
 Id INT NOT NULL IDENTITY(1,1),
 FirstName VARCHAR(200),
 LastName VARCHAR(200),
 DateBirth DATE,
 Gender BIT,
 Address VARCHAR(500),
 Email VARCHAR(200),
 Telephone VARCHAR(25),
 JobTitle INT,
 ProtectedAreaId INT NOT NULL,
 CreateAt datetime,
 CreatedBy INT,
 UpdateAt datetime,
 UpdatedBy INT,
 Status BIT DEFAULT 1
);

ALTER TABLE Researcher ADD CONSTRAINT PK_Researcher PRIMARY KEY (Id);


CREATE TABLE Species (
 Id INT NOT NULL IDENTITY(1,1),
 CommonName VARCHAR(200),
 ScientificName VARCHAR(200),
 Code VARCHAR(10),
 ConservationStatus INT,
 PopulationTrend INT,
 HabitatEcology VARCHAR(500),
 CreateAt datetime,
 CreatedBy INT,
 UpdateAt datetime,
 UpdatedBy INT,
 Status BIT DEFAULT 1
);

ALTER TABLE Species ADD CONSTRAINT PK_Species PRIMARY KEY (Id);


CREATE TABLE UserAccount (
 Id INT NOT NULL,
 UserName VARCHAR(100),
 Password VARCHAR(20),
 IsActive BIT DEFAULT 1
);

ALTER TABLE UserAccount ADD CONSTRAINT PK_UserAccount PRIMARY KEY (Id);


CREATE TABLE Animal (
 Id INT NOT NULL IDENTITY(1,1),
 SpeciesId INT NOT NULL,
 FamilyId INT NOT NULL,
 GenusId INT NOT NULL,
 Name VARCHAR(250),
 Description VARCHAR(300),
 Gender BIT,
 CaptureDate datetime,
 CaptureCondition VARCHAR(500),
 Weight FLOAT(10),
 Height FLOAT(10),
 EstimatedAge INT,
 CreateAt datetime,
 CreatedBy INT,
 UpdateAt datetime,
 UpdatedBy INT,
 Status BIT DEFAULT 1
);

ALTER TABLE Animal ADD CONSTRAINT PK_Animal PRIMARY KEY (Id);


CREATE TABLE Photo (
 Id INT NOT NULL IDENTITY(1,1),
 FileName VARCHAR(100),
 Url VARCHAR(250),
 AnimalId INT NOT NULL,
 CreateAt datetime,
 CreatedBy INT,
 UpdateAt datetime,
 UpdatedBy INT,
 Status BIT DEFAULT 1
);

ALTER TABLE Photo ADD CONSTRAINT PK_Photo PRIMARY KEY (Id);


CREATE TABLE RFIdTag (
 Id INT NOT NULL,
 Tag VARCHAR(20),
 DateEstablished datetime,
 ProtectedAreaId INT NOT NULL
);

ALTER TABLE RFIdTag ADD CONSTRAINT PK_RFIdTag PRIMARY KEY (Id);


CREATE TABLE Sighting (
 Id INT NOT NULL IDENTITY(1,1),
 RegisterDate datetime NOT NULL,
 GeoPOI geography,
 Observation VARCHAR(500),
 AnimalId INT,
 ResearcherId INT,
 CreateAt datetime,
 CreatedBy INT,
 UpdateAt datetime,
 UpdatedBy INT,
 Status BIT DEFAULT 1
);

ALTER TABLE Sighting ADD CONSTRAINT PK_Sighting PRIMARY KEY (Id);


ALTER TABLE ProtectedArea ADD CONSTRAINT FK_ProtectedArea_0 FOREIGN KEY (CountryId) REFERENCES Country (Id);


ALTER TABLE Researcher ADD CONSTRAINT FK_Researcher_0 FOREIGN KEY (ProtectedAreaId) REFERENCES ProtectedArea (Id);


ALTER TABLE UserAccount ADD CONSTRAINT FK_UserAccount_0 FOREIGN KEY (Id) REFERENCES Researcher (Id);


ALTER TABLE Animal ADD CONSTRAINT FK_Animal_0 FOREIGN KEY (SpeciesId) REFERENCES Species (Id);
ALTER TABLE Animal ADD CONSTRAINT FK_Animal_1 FOREIGN KEY (FamilyId) REFERENCES Family (Id);
ALTER TABLE Animal ADD CONSTRAINT FK_Animal_2 FOREIGN KEY (GenusId) REFERENCES Genus (Id);


ALTER TABLE Photo ADD CONSTRAINT FK_Photo_0 FOREIGN KEY (AnimalId) REFERENCES Animal (Id);


ALTER TABLE RFIdTag ADD CONSTRAINT FK_RFIdTag_0 FOREIGN KEY (Id) REFERENCES Animal (Id);
ALTER TABLE RFIdTag ADD CONSTRAINT FK_RFIdTag_1 FOREIGN KEY (ProtectedAreaId) REFERENCES ProtectedArea (Id);


ALTER TABLE Sighting ADD CONSTRAINT FK_Sighting_0 FOREIGN KEY (AnimalId) REFERENCES Animal (Id);
ALTER TABLE Sighting ADD CONSTRAINT FK_Sighting_1 FOREIGN KEY (ResearcherId) REFERENCES Researcher (Id);






