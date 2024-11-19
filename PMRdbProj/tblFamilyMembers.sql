CREATE TABLE [dbo].[tblFamilyMembers]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Lastname] VARCHAR(50) NULL, 
    [Firstname] VARCHAR(50) NOT NULL, 
    [Alive] BIT NULL, 
    [DOB] DATE NULL, 
    [DOD] DATE NULL, 
    [ApproxYear_Birth] VARCHAR(10) NULL, 
    [ApproxYear_Death] VARCHAR(10) NULL, 
    [Notes] VARCHAR(MAX) NULL
)
