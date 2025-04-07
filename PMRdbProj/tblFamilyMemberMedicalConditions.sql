CREATE TABLE [dbo].[tblFamilyMemberMedicalConditions](
	[FamilyMemberMedicalConditionId] [int] IDENTITY(1,1) NOT NULL,
	[FamilyMemberID] [int] NOT NULL,
	[SelectMedicalConditionID] [int] NOT NULL,
	[AgeOnsetCondition] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[FamilyMemberMedicalConditionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
