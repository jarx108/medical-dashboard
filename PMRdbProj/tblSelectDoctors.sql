CREATE TABLE [dbo].[tblSelectDoctors](
	[SelectDoctorId] [int] IDENTITY(1,1) NOT NULL,
	[Lastname] [varchar](50) NOT NULL,
	[Firstname] [varchar](50) NOT NULL,
	[Specialty] [varchar](30) NOT NULL,
	[Location] [varchar](100) NULL,
	[Phone] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[SelectDoctorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]