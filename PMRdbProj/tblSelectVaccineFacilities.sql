CREATE TABLE [dbo].[tblSelectVaccineFacilities]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Location] VARCHAR(100) NULL, 
    [Phone] INT NULL
)
