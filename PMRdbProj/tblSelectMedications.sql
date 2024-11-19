CREATE TABLE [dbo].[tblSelectMedications]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NOT NULL, 
    [ManufacturerID] INT NULL, 
    [Strength] VARCHAR(20) NULL, 
    CONSTRAINT [FK_tblSelectMedications_tblSelectManufacturer] FOREIGN KEY ([ManufacturerID]) REFERENCES [tblSelectManufacturer]([Id])
)
