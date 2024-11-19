CREATE TABLE [dbo].[tblVaccineDetails]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [VaccinesID] INT NOT NULL, 
    [DetailedName] VARCHAR(50) NOT NULL, 
    [VaccineGroupNameID] INT NULL, 
    [DateGiven] DATE NOT NULL, 
    [VaccineFacilitiesID] INT NULL, 
    [ManufacturerID] INT NULL, 
    [RXNum] VARCHAR(20) NULL, 
    [NDCNum] VARCHAR(20) NULL, 
    [LotNum] VARCHAR(20) NULL, 
    [Notes] VARCHAR(MAX) NULL, 
    [PDFFile] VARBINARY(MAX) NULL, 
    [ImgFile] IMAGE NULL, 
    CONSTRAINT [FK_tblVaccineDetails_tblVaccines] FOREIGN KEY ([VaccinesID]) REFERENCES [tblVaccines]([Id]),
    CONSTRAINT [FK_tblVaccineDetails_tbSelectlVaccineGroupName] FOREIGN KEY ([VaccineGroupNameID]) REFERENCES [tblSelectVaccineGroupName]([Id]),
    CONSTRAINT [FK_tblVaccineDetails_tblSelectVaccineFacilities] FOREIGN KEY ([VaccineFacilitiesID]) REFERENCES [tblSelectVaccineFacilities]([Id]),
    CONSTRAINT [FK_tblVaccineDetails_tblSelectManufacturer] FOREIGN KEY ([ManufacturerID]) REFERENCES [tblSelectManufacturer]([Id])
)
