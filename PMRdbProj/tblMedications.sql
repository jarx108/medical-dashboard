CREATE TABLE [dbo].[tblMedications]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserID] INT NOT NULL, 
    [MedicationID] INT NOT NULL, 
    [DoctorID] INT NULL, 
    [MedicalConditionID] INT NULL, 
    [PharmacyID] INT NULL, 
    [Date] DATE NULL, 
    [RXNumber] VARCHAR(30) NULL, 
    [Qty] INT NULL, 
    [Dosing] VARCHAR(30) NULL, 
    [Notes] VARCHAR(MAX) NULL, 
    [PDFFile] VARBINARY(MAX) NULL, 
    [ImgFile] IMAGE NULL, 
    CONSTRAINT [FK_tblMedications_tblUsernames] FOREIGN KEY ([UserID]) REFERENCES [tblUsernames]([Id]),
    CONSTRAINT [FK_tblMedications_tblSelectMedications] FOREIGN KEY ([MedicationID]) REFERENCES [tblSelectMedications]([Id]),
    CONSTRAINT [FK_tblMedications_tblSelectDoctors] FOREIGN KEY ([DoctorID]) REFERENCES [tblSelectDoctors]([Id]),
    CONSTRAINT [FK_tblMedications_tblSelectMedicalConditions] FOREIGN KEY ([MedicalConditionID]) REFERENCES [tblSelectMedicalConditions]([Id]),
    CONSTRAINT [FK_tblMedications_tblSelectPharmacies] FOREIGN KEY ([PharmacyID]) REFERENCES [tblSelectPharmacies]([Id])

)
