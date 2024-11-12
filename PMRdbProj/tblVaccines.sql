CREATE TABLE [dbo].[tblVaccines]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NCHAR(60) NULL, 
    [Abbreviation] NCHAR(10) NULL, 
    [NumDoses] INT NULL, 
    [LastDose] DATE NULL, 
    [UserID] INT NULL
)
