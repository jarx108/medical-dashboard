CREATE TABLE [dbo].[tblSelectFamilyMembers](
	[SelectFamilyMemberId] [int] IDENTITY(1,1) NOT NULL,
	[Lastname] [varchar](50) NOT NULL,
	[Firstname] [varchar](50) NOT NULL,
	[Alive] [bit] NULL,
	[DOB] [date] NULL,
	[DOD] [date] NULL,
	[ApproxYear_Birth] [varchar](10) NULL,
	[ApproxYear_Death] [varchar](10) NULL,
	[Notes] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[SelectFamilyMemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]