CREATE TABLE [dbo].[tblDoctorVisits]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserID] INT NOT NULL, 
    [DoctorID] INT NOT NULL, 
    [MedicalConditionID] INT NULL, 
    [Date] DATE NULL, 
    [Notes] VARCHAR(MAX) NULL, 
    [PDFFile] VARBINARY(MAX) NULL, 
    [ImgFile] IMAGE NULL, 
    CONSTRAINT [FK_tblDoctorVisits_tblUsernames] FOREIGN KEY ([UserID]) REFERENCES [tblUsernames]([Id]),
    CONSTRAINT [FK_tblDoctorVisits_tblSelectDoctors] FOREIGN KEY ([DoctorID]) REFERENCES [tblSelectDoctors]([Id]),
    CONSTRAINT [FK_tblDoctorVisits_tblSelectMedicalConditions] FOREIGN KEY ([MedicalConditionID]) REFERENCES [tblSelectMedicalConditions]([Id])
)

