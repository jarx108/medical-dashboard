CREATE TABLE [dbo].[tblMedicationLists](
	[MedicationListId] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[SelectMedicationID] [int] NOT NULL,
	[SelectionDoctorID] [int] NULL,
	[SelectMedicalConditionID] [int] NULL,
	[SelectFacilityID] [int] NULL,
	[MedicationListDate] [date] NULL,
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
