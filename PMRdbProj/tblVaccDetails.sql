CREATE TABLE [dbo].[tblVaccDetails]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [DetailedName] NCHAR(60) NULL, 
    [DateGiven] DATE NULL, 
    [GivenBy] NCHAR(30) NULL, 
    [Manufacturer] NCHAR(20) NULL, 
    [RXNum] NCHAR(20) NULL, 
    [NDCNum] NCHAR(20) NULL, 
    [LotNum] NCHAR(20) NULL, 
    [Notes] VARCHAR(MAX) NULL, 
    [PDFFile] VARBINARY(MAX) NULL, 
    [ImgFile] IMAGE NULL, 
    [VacMainID] INT NULL
)
