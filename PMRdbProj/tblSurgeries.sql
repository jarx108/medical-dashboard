CREATE TABLE [dbo].[tblSurgeries](
	[SurgeryId] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[SelectFacilityID] [int] NULL,
	[SelectDoctorID] [int] NULL,
	[SurgeryDate] [date] NULL,
	[SelectMedicalConditionID] [int] NOT NULL,
	[Notes] [varchar](max) NULL,
	[PDFFile] [varbinary](max) NULL,
	[ImgFile] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[SurgeryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
