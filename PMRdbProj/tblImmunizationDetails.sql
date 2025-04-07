CREATE TABLE [dbo].[tblImmunizationDetails](
	[ImmunizationDetailsId] [int] IDENTITY(1,1) NOT NULL,
	[SelectVaccineNameID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[DetailName] [varchar](50) NULL,
	[DateGiven] [date] NOT NULL,
	[SelectFacilityID] [int] NULL,
	[SelectManufacturerID] [int] NULL,
	[RXNum] [varchar](20) NULL,
	[NDCNum] [varchar](20) NULL,
	[LotNum] [varchar](20) NULL,
	[Notes] [varchar](max) NULL,
	[PDFFile] [varbinary](max) NULL,
	[ImgFile] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[ImmunizationDetailsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
