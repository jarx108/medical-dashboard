CREATE TABLE [dbo].[tblTests]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserID] INT NOT NULL, 
    [TestTypeID] INT NOT NULL, 
    [BodyPart] VARCHAR(30) NULL, 
    [DoctorID] INT NULL, 
    [TestCenterID] INT NULL, 
    [MedicalConditionID] INT NULL, 
    [Results] VARCHAR(50) NULL, 
    [Date] DATE NULL, 
    [Notes] VARCHAR(MAX) NULL, 
    [PDFFile] VARBINARY(MAX) NULL, 
    [ImgFile] IMAGE NULL, 
    CONSTRAINT [FK_tblTests_tblUsernames] FOREIGN KEY ([UserID]) REFERENCES [tblUsernames]([Id]),
    CONSTRAINT [FK_tblTests_tblSelectTestTypes] FOREIGN KEY ([TestTypeID]) REFERENCES [tblSelectTestTypes]([Id]),
    CONSTRAINT [FK_tblTests_tblSelectDoctors] FOREIGN KEY ([DoctorID]) REFERENCES [tblSelectDoctors]([Id]),
    CONSTRAINT [FK_tblTests_tblSelectTestCenter] FOREIGN KEY ([TestCenterID]) REFERENCES [tblSelectTestCenter]([Id]),
    CONSTRAINT [FK_tblTests_tblSelectMedicalConditions] FOREIGN KEY ([MedicalConditionID]) REFERENCES [tblSelectMedicalConditions]([Id])
)
