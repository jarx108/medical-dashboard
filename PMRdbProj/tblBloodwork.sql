CREATE TABLE [dbo].[tblBloodwork]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserID] INT NULL, 
    [BloodworkIndiNameID] INT NULL, 
    [Result] VARCHAR(10) NULL, 
    [DoctorID] INT NULL, 
    [Date] DATE NULL, 
    [BloodworkDrawFacilityID] INT NULL, 
    [Notes] VARCHAR(MAX) NULL, 
    [PDFFile] VARBINARY(MAX) NULL, 
    [ImgFile] IMAGE NULL, 
    CONSTRAINT [FK_tblBloodwork_tblUsernames] FOREIGN KEY ([UserID]) REFERENCES [tblUsernames]([Id]),
    CONSTRAINT [FK_tblBloodwork_tblSelectBloodworkIndiName] FOREIGN KEY ([BloodworkIndiNameID]) REFERENCES [tblSelectBloodworkIndiName]([Id]),
    CONSTRAINT [FK_tblBloodwork_tblSelectDoctors] FOREIGN KEY ([DoctorID]) REFERENCES [tblSelectDoctors]([Id]),
    CONSTRAINT [FK_tblBloodwork_tblSelectBloodworkDrawFacility] FOREIGN KEY ([BloodworkDrawFacilityID]) REFERENCES [tblSelectBloodworkDrawFacility]([Id])
)
