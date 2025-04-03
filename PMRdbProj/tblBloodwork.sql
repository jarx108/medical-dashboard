CREATE TABLE [dbo].[tblBloodwork](
	[BloodworkId] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[SelectBloodworkIndiNameID] [int] NOT NULL,
	[Result] [varchar](10) NOT NULL,
	[SelectDoctorID] [int] NULL,
	[Date] [date] NULL,
	[SelectFacilityID] [int] NULL,
	[Notes] [varchar](max) NULL,
	[PDFFile] [varbinary](max) NULL,
	[ImgFile] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[BloodworkId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblBloodwork]  WITH CHECK ADD  CONSTRAINT [FK_tblBloodwork_tblSelectBloodworkIndiNames] FOREIGN KEY([SelectBloodworkIndiNameID])
REFERENCES [dbo].[tblSelectBloodworkIndiNames] ([SelectBloodworkIndiNameId])
GO

ALTER TABLE [dbo].[tblBloodwork] CHECK CONSTRAINT [FK_tblBloodwork_tblSelectBloodworkIndiNames]
GO


GO
ALTER TABLE [dbo].[tblBloodwork]  WITH CHECK ADD  CONSTRAINT [FK_tblBloodwork_tblSelectDoctors] FOREIGN KEY([SelectDoctorID])
REFERENCES [dbo].[tblSelectDoctors] ([SelectDoctorId])
GO

ALTER TABLE [dbo].[tblBloodwork] CHECK CONSTRAINT [FK_tblBloodwork_tblSelectDoctors]
GO


GO
ALTER TABLE [dbo].[tblBloodwork]  WITH CHECK ADD  CONSTRAINT [FK_tblBloodwork_tblSelectFacilities] FOREIGN KEY([SelectFacilityID])
REFERENCES [dbo].[tblSelectFacilities] ([FacilityId])
GO

ALTER TABLE [dbo].[tblBloodwork] CHECK CONSTRAINT [FK_tblBloodwork_tblSelectFacilities]
GO
ALTER TABLE [dbo].[tblBloodwork]  WITH CHECK ADD  CONSTRAINT [FK_tblBloodwork_tblUsers] FOREIGN KEY([UserID])
REFERENCES [dbo].[tblUsers] ([UserId])
GO

ALTER TABLE [dbo].[tblBloodwork] CHECK CONSTRAINT [FK_tblBloodwork_tblUsers]
GO
ALTER TABLE [dbo].[tblBloodwork]  WITH CHECK ADD  CONSTRAINT [FK_tblBloodwork_tblSelectFacilities1] FOREIGN KEY([SelectFacilityID])
REFERENCES [dbo].[tblSelectFacilities] ([SelectFacilityId])
GO

ALTER TABLE [dbo].[tblBloodwork] CHECK CONSTRAINT [FK_tblBloodwork_tblSelectFacilities1]