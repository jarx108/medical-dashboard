CREATE TABLE [dbo].[tblHospitalizations](
	[HospitalizationId] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[SelectMedicalConditionID] [int] NOT NULL,
	[SelectDoctorID] [int] NULL,
	[SelectFacilityID] [int] NULL,
	[AdmissionDate] [date] NULL,
	[DischargeDate] [date] NULL,
	[Notes] [varchar](max) NULL,
	[PDFFile] [varbinary](max) NULL,
	[ImgFile] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[HospitalizationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblHospitalizations]  WITH CHECK ADD  CONSTRAINT [FK_tblHospitalizations_tblSelectDoctors] FOREIGN KEY([SelectDoctorID])
REFERENCES [dbo].[tblSelectDoctors] ([SelectDoctorId])
GO

ALTER TABLE [dbo].[tblHospitalizations] CHECK CONSTRAINT [FK_tblHospitalizations_tblSelectDoctors]
GO


GO
ALTER TABLE [dbo].[tblHospitalizations]  WITH CHECK ADD  CONSTRAINT [FK_tblHospitalizations_tblSelectFacilities] FOREIGN KEY([SelectFacilityID])
REFERENCES [dbo].[tblSelectFacilities] ([SelectFacilityId])
GO

ALTER TABLE [dbo].[tblHospitalizations] CHECK CONSTRAINT [FK_tblHospitalizations_tblSelectFacilities]
GO


GO
ALTER TABLE [dbo].[tblHospitalizations]  WITH CHECK ADD  CONSTRAINT [FK_tblHospitalizations_tblSelectMedicalConditions] FOREIGN KEY([SelectMedicalConditionID])
REFERENCES [dbo].[tblSelectMedicalConditions] ([SelectMedicalConditionId])
GO

ALTER TABLE [dbo].[tblHospitalizations] CHECK CONSTRAINT [FK_tblHospitalizations_tblSelectMedicalConditions]
GO


GO
ALTER TABLE [dbo].[tblHospitalizations]  WITH CHECK ADD  CONSTRAINT [FK_tblHospitalizations_tblUsers] FOREIGN KEY([UserID])
REFERENCES [dbo].[tblUsers] ([UserId])
GO

ALTER TABLE [dbo].[tblHospitalizations] CHECK CONSTRAINT [FK_tblHospitalizations_tblUsers]
GO

