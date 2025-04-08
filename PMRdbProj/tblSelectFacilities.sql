CREATE TABLE [dbo].[tblSelectFacilities](
	[SelectFacilityId] [int] IDENTITY(1,1) NOT NULL,
	[SelectFacilityName] [varchar](50) NOT NULL,
	[Location] [varchar](100) NULL,
	[Phone] [varchar](20) NULL,
	[isHospital] [bit] NULL,
	[isPharmacy] [bit] NULL,
	[isSurgery] [bit] NULL,
	[isTestCenter] [bit] NULL,
	[isDoctorOffice] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[SelectFacilityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]