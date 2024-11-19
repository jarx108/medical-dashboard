CREATE TABLE [dbo].[tblSelectDoctors]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Lastname] VARCHAR(50) NOT NULL, 
    [Firstname] VARCHAR(50) NOT NULL, 
    [Specialty] VARCHAR(30) NOT NULL, 
    [Location] VARCHAR(100) NULL, 
    [Phone] INT NULL
)
