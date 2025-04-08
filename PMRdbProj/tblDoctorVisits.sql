CREATE TABLE [dbo].[tblDoctorVisits](
	[DoctorVisitId] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[SelectDoctorID] [int] NOT NULL,
	[SelectMedicalConditionID] [int] NOT NULL,
	[DoctorVisitDate] [date] NULL,
	[Notes] [varchar](max) NULL,
	[PDFFile] [varbinary](max) NULL,
	[ImgFile] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[DoctorVisitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
