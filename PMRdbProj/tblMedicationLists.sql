CREATE TABLE [dbo].[tblMedicationLists](
	[MedicationListId] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[SelectMedicationID] [int] NOT NULL,
	[SelectionDoctorID] [int] NULL,
	[SelectMedicalConditionID] [int] NULL,
	[SelectFacilityID] [int] NULL,
	[Date] [date] NULL,
	[RXNumber] [varchar](30) NULL,
	[Qty] [int] NULL,
	[Dosing] [varchar](30) NULL,
	[Notes] [varchar](max) NULL,
	[PDFFile] [varbinary](max) NULL,
	[ImgFile] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[MedicationListId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblMedicationLists]  WITH CHECK ADD  CONSTRAINT [FK_tblMedicationLists_tblSelectDoctors] FOREIGN KEY([SelectionDoctorID])
REFERENCES [dbo].[tblSelectDoctors] ([SelectDoctorId])
GO

ALTER TABLE [dbo].[tblMedicationLists] CHECK CONSTRAINT [FK_tblMedicationLists_tblSelectDoctors]
GO


GO
ALTER TABLE [dbo].[tblMedicationLists]  WITH CHECK ADD  CONSTRAINT [FK_tblMedicationLists_tblSelectFacilities] FOREIGN KEY([SelectFacilityID])
REFERENCES [dbo].[tblSelectFacilities] ([SelectFacilityId])
GO

ALTER TABLE [dbo].[tblMedicationLists] CHECK CONSTRAINT [FK_tblMedicationLists_tblSelectFacilities]
GO


GO
ALTER TABLE [dbo].[tblMedicationLists]  WITH CHECK ADD  CONSTRAINT [FK_tblMedicationLists_tblSelectMedicalConditions] FOREIGN KEY([SelectMedicalConditionID])
REFERENCES [dbo].[tblSelectMedicalConditions] ([SelectMedicalConditionId])
GO

ALTER TABLE [dbo].[tblMedicationLists] CHECK CONSTRAINT [FK_tblMedicationLists_tblSelectMedicalConditions]
GO


GO
ALTER TABLE [dbo].[tblMedicationLists]  WITH CHECK ADD  CONSTRAINT [FK_tblMedicationLists_tblSelectMedications] FOREIGN KEY([SelectMedicationID])
REFERENCES [dbo].[tblSelectMedications] ([SelectMedicationID])
GO

ALTER TABLE [dbo].[tblMedicationLists] CHECK CONSTRAINT [FK_tblMedicationLists_tblSelectMedications]
GO


GO
ALTER TABLE [dbo].[tblMedicationLists]  WITH CHECK ADD  CONSTRAINT [FK_tblMedicationLists_tblUsers] FOREIGN KEY([UserID])
REFERENCES [dbo].[tblUsers] ([UserId])
GO

ALTER TABLE [dbo].[tblMedicationLists] CHECK CONSTRAINT [FK_tblMedicationLists_tblUsers]
GO

