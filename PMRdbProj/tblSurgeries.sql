CREATE TABLE [dbo].[tblSurgeries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[SelectFacilityID] [int] NULL,
	[SelectDoctorID] [int] NULL,
	[Date] [date] NULL,
	[SelectMedicalConditionID] [int] NOT NULL,
	[Notes] [varchar](max) NULL,
	[PDFFile] [varbinary](max) NULL,
	[ImgFile] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblSurgeries]  WITH CHECK ADD  CONSTRAINT [FK_tblSurgeries_tblSelectDoctors] FOREIGN KEY([SelectDoctorID])
REFERENCES [dbo].[tblSelectDoctors] ([SelectDoctorId])
GO

ALTER TABLE [dbo].[tblSurgeries] CHECK CONSTRAINT [FK_tblSurgeries_tblSelectDoctors]
GO


GO
ALTER TABLE [dbo].[tblSurgeries]  WITH CHECK ADD  CONSTRAINT [FK_tblSurgeries_tblSelectFacilities] FOREIGN KEY([SelectFacilityID])
REFERENCES [dbo].[tblSelectFacilities] ([SelectFacilityId])
GO

ALTER TABLE [dbo].[tblSurgeries] CHECK CONSTRAINT [FK_tblSurgeries_tblSelectFacilities]
GO


GO
ALTER TABLE [dbo].[tblSurgeries]  WITH CHECK ADD  CONSTRAINT [FK_tblSurgeries_tblSelectMedicalConditions] FOREIGN KEY([SelectMedicalConditionID])
REFERENCES [dbo].[tblSelectMedicalConditions] ([SelectMedicalConditionId])
GO

ALTER TABLE [dbo].[tblSurgeries] CHECK CONSTRAINT [FK_tblSurgeries_tblSelectMedicalConditions]
GO


GO
ALTER TABLE [dbo].[tblSurgeries]  WITH CHECK ADD  CONSTRAINT [FK_tblSurgeries_tblUsers] FOREIGN KEY([UserID])
REFERENCES [dbo].[tblUsers] ([UserId])
GO

ALTER TABLE [dbo].[tblSurgeries] CHECK CONSTRAINT [FK_tblSurgeries_tblUsers]
GO

