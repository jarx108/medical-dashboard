CREATE TABLE [dbo].[tblSurgeries]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserID] INT NOT NULL, 
    [SurgeryCentersID] INT NULL, 
    [DoctorID] INT NULL, 
    [Date] DATE NULL, 
    [MedicalConditionID] INT NULL, 
    [Notes] VARCHAR(MAX) NULL, 
    [PDFFile] VARBINARY(MAX) NULL, 
    [ImgFile] IMAGE NULL, 
    CONSTRAINT [FK_tblSurgeries_tblUsernames] FOREIGN KEY ([UserID]) REFERENCES [tblUsernames]([Id]),
    CONSTRAINT [FK_tblSurgeries_tblSelectSurgeryCenters] FOREIGN KEY ([SurgeryCentersID]) REFERENCES [tblSelectSurgeryCenters]([ID]),
    CONSTRAINT [FK_tblSurgeries_tblSelectDoctors] FOREIGN KEY ([DoctorID]) REFERENCES [tblSelectDoctors]([Id]),
    CONSTRAINT [FK_tblSurgeries_tblSelectMedicalConditions] FOREIGN KEY ([MedicalConditionID]) REFERENCES [tblSelectMedicalConditions]([Id])

)
