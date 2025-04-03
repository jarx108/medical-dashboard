CREATE TABLE [dbo].[tblDoctorVisits](
	[DoctorVisitId] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[SelectDoctorID] [int] NOT NULL,
	[SelectMedicalConditionID] [int] NOT NULL,
	[Date] [date] NULL,
	[Notes] [varchar](max) NULL,
	[PDFFile] [varbinary](max) NULL,
	[ImgFile] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[DoctorVisitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblDoctorVisits]  WITH CHECK ADD  CONSTRAINT [FK_tblDoctorVisits_tblSelectDoctors] FOREIGN KEY([SelectDoctorID])
REFERENCES [dbo].[tblSelectDoctors] ([SelectDoctorId])
GO

ALTER TABLE [dbo].[tblDoctorVisits] CHECK CONSTRAINT [FK_tblDoctorVisits_tblSelectDoctors]
GO


GO
ALTER TABLE [dbo].[tblDoctorVisits]  WITH CHECK ADD  CONSTRAINT [FK_tblDoctorVisits_tblSelectMedicalConditions] FOREIGN KEY([SelectMedicalConditionID])
REFERENCES [dbo].[tblSelectMedicalConditions] ([SelectMedicalConditionId])
GO

ALTER TABLE [dbo].[tblDoctorVisits] CHECK CONSTRAINT [FK_tblDoctorVisits_tblSelectMedicalConditions]
GO


GO
ALTER TABLE [dbo].[tblDoctorVisits]  WITH CHECK ADD  CONSTRAINT [FK_tblDoctorVisits_tblUsers] FOREIGN KEY([UserID])
REFERENCES [dbo].[tblUsers] ([UserId])
GO

ALTER TABLE [dbo].[tblDoctorVisits] CHECK CONSTRAINT [FK_tblDoctorVisits_tblUsers]
GO

