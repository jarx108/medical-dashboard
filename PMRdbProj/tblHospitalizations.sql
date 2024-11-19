CREATE TABLE [dbo].[tblHospitalizations]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserID] INT NOT NULL, 
    [MedicalConditionID] INT NULL, 
    [DoctorID] INT NULL, 
    [HospitalID] INT NULL, 
    [AdmissionDate] DATE NULL, 
    [DischargeDate] DATE NULL, 
    [Notes] VARCHAR(MAX) NULL, 
    [PDFFile] VARBINARY(MAX) NULL, 
    [ImgFile] IMAGE NULL, 
    CONSTRAINT [FK_tblHospitalizations_tblUsernames] FOREIGN KEY ([UserID]) REFERENCES [tblUsernames]([Id]),
    CONSTRAINT [FK_tblHospitalizations_tblSelectMedicalConditions] FOREIGN KEY ([MedicalConditionID]) REFERENCES [tblSelectMedicalConditions]([Id]),
    CONSTRAINT [FK_tblHospitalizations_tblSelectDoctors] FOREIGN KEY ([DoctorID]) REFERENCES [tblSelectDoctors]([Id]),
    CONSTRAINT [FK_tblHospitalizations_tblSelectHospitals] FOREIGN KEY ([HospitalID]) REFERENCES [tblSelectHospitals]([Id])
)
