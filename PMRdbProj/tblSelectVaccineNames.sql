CREATE TABLE [dbo].[tblSelectVaccineNames](
	[SelectVaccineNameID] [int] NOT NULL,
	[VaccineName] [varchar](50) NOT NULL,
	[SelectVaccineGroupID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SelectVaccineNameID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblSelectVaccineNames]  WITH CHECK ADD  CONSTRAINT [FK_tblSelectVaccineNames_tblSelectVaccineGroupNames] FOREIGN KEY([SelectVaccineGroupID])
REFERENCES [dbo].[tblSelectVaccineGroupNames] ([SelectVaccineGroupId])
GO

ALTER TABLE [dbo].[tblSelectVaccineNames] CHECK CONSTRAINT [FK_tblSelectVaccineNames_tblSelectVaccineGroupNames]
GO

