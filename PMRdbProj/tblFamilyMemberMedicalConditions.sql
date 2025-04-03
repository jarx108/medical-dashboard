CREATE TABLE [dbo].[tblFamilyMemberMedicalConditions](
	[FamilyMemberMedicalConditionId] [int] IDENTITY(1,1) NOT NULL,
	[SelectFamilyMemberID] [int] NOT NULL,
	[SelectMedicalConditionID] [int] NOT NULL,
	[AgeOnsetCondition] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[FamilyMemberMedicalConditionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblFamilyMemberMedicalConditions]  WITH CHECK ADD  CONSTRAINT [FK_tblFamilyMemberMedicalConditions_tblFamilyMembers] FOREIGN KEY([SelectFamilyMemberID])
REFERENCES [dbo].[tblSelectFamilyMembers] ([SelectFamilyMemberId])
GO

ALTER TABLE [dbo].[tblFamilyMemberMedicalConditions] CHECK CONSTRAINT [FK_tblFamilyMemberMedicalConditions_tblFamilyMembers]
GO


GO
ALTER TABLE [dbo].[tblFamilyMemberMedicalConditions]  WITH CHECK ADD  CONSTRAINT [FK_tblFamilyMemberMedicalConditions_tblSelectMedicalConditions] FOREIGN KEY([SelectMedicalConditionID])
REFERENCES [dbo].[tblSelectMedicalConditions] ([SelectMedicalConditionId])
GO

ALTER TABLE [dbo].[tblFamilyMemberMedicalConditions] CHECK CONSTRAINT [FK_tblFamilyMemberMedicalConditions_tblSelectMedicalConditions]
GO

