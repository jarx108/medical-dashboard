CREATE TABLE [dbo].[tblFamilyMemberMedicalConditions]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FamilyMemberID] INT NOT NULL, 
    [MedicalConditionID] INT NOT NULL, 
    [AgeOnsetCondition] INT NULL, 
    CONSTRAINT [FK_tblFamilyMemberMedicalConditions_tblFamilyMembers] FOREIGN KEY ([FamilyMemberID]) REFERENCES [tblFamilyMembers]([ID]),
    CONSTRAINT [FK_tblFamilyMemberMedicalConditions_tblSelectMedicalConditions] FOREIGN KEY ([MedicalConditionID]) REFERENCES [tblSelectMedicalConditions]([ID])
)
