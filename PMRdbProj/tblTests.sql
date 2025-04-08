CREATE TABLE [dbo].[tblTests](
	[TestsID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[SelectTestTypeID] [int] NOT NULL,
	[BodyPart] [varchar](30) NULL,
	[SelectDoctorID] [int] NULL,
	[SelectFacilityID] [int] NULL,
	[SelectMedicalConditionID] [int] NULL,
	[Results] [varchar](50) NULL,
	[TestDate] [date] NULL,
	[Notes] [varchar](max) NULL,
	[PDFFile] [varbinary](max) NULL,
	[ImgFile] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[TestsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
