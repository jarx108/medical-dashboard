CREATE TABLE [dbo].[tblSelectMedications](
	[SelectMedicationID] [int] IDENTITY(1,1) NOT NULL,
	[MedicationName] [varchar](50) NOT NULL,
	[SelectManufacturerID] [int] NULL,
	[Strength] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[SelectMedicationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblSelectMedications]  WITH CHECK ADD  CONSTRAINT [FK_tblSelectMedications_tblSelectManufacturers] FOREIGN KEY([SelectManufacturerID])
REFERENCES [dbo].[tblSelectManufacturers] ([SelectManufacturerId])
GO

ALTER TABLE [dbo].[tblSelectMedications] CHECK CONSTRAINT [FK_tblSelectMedications_tblSelectManufacturers]
GO

