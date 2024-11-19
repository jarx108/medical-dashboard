CREATE TABLE [dbo].[tblSelectSurgeryCenters]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Location] VARCHAR(MAX) NULL, 
    [Phone] INT NULL
)
