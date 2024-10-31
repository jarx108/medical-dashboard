CREATE TABLE [dbo].[tblUsernames]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Username] NCHAR(50) NULL, 
    [Password] NCHAR(30) NULL, 
    [Lastname] NCHAR(50) NULL, 
    [Firstname] NCHAR(50) NULL, 
    [DOB] DATE NULL
)
