CREATE TABLE [dbo].[tblTests](
	[TestsID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[SelectTestTypeID] [int] NOT NULL,
	[BodyPart] [varchar](30) NULL,
	[SelectDoctorID] [int] NULL,
	[SelectFacilityID] [int] NULL,
	[SelectMedicalConditionID] [int] NULL,
	[Results] [varchar](50) NULL,
	[Date] [date] NULL,
	[Notes] [varchar](max) NULL,
	[PDFFile] [varbinary](max) NULL,
	[ImgFile] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[TestsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblTests]  WITH CHECK ADD  CONSTRAINT [FK_tblTests_tblSelectDoctors] FOREIGN KEY([SelectDoctorID])
REFERENCES [dbo].[tblSelectDoctors] ([SelectDoctorId])
GO

ALTER TABLE [dbo].[tblTests] CHECK CONSTRAINT [FK_tblTests_tblSelectDoctors]
GO


GO
ALTER TABLE [dbo].[tblTests]  WITH CHECK ADD  CONSTRAINT [FK_tblTests_tblSelectFacilities] FOREIGN KEY([SelectFacilityID])
REFERENCES [dbo].[tblSelectFacilities] ([SelectFacilityId])
GO

ALTER TABLE [dbo].[tblTests] CHECK CONSTRAINT [FK_tblTests_tblSelectFacilities]
GO


GO
ALTER TABLE [dbo].[tblTests]  WITH CHECK ADD  CONSTRAINT [FK_tblTests_tblSelectMedicalConditions] FOREIGN KEY([SelectMedicalConditionID])
REFERENCES [dbo].[tblSelectMedicalConditions] ([SelectMedicalConditionId])
GO

ALTER TABLE [dbo].[tblTests] CHECK CONSTRAINT [FK_tblTests_tblSelectMedicalConditions]
GO


GO
ALTER TABLE [dbo].[tblTests]  WITH CHECK ADD  CONSTRAINT [FK_tblTests_tblSelectTestTypes] FOREIGN KEY([SelectTestTypeID])
REFERENCES [dbo].[tblSelectTestTypes] ([SelectTestTypeId])
GO

ALTER TABLE [dbo].[tblTests] CHECK CONSTRAINT [FK_tblTests_tblSelectTestTypes]
GO


GO
ALTER TABLE [dbo].[tblTests]  WITH CHECK ADD  CONSTRAINT [FK_tblTests_tblUsers] FOREIGN KEY([UserID])
REFERENCES [dbo].[tblUsers] ([UserId])
GO

ALTER TABLE [dbo].[tblTests] CHECK CONSTRAINT [FK_tblTests_tblUsers]
GO

