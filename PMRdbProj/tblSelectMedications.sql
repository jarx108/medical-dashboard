CREATE TABLE [dbo].[tblSelectMedications](
	[SelectMedicationID] [int] IDENTITY(1,1) NOT NULL,
	[MedicationName] [varchar](100) NOT NULL,
	[SelectManufacturerID] [int] NULL,
	[Strength] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[SelectMedicationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
