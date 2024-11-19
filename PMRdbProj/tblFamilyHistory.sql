CREATE TABLE [dbo].[tblFamilyHistory]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserID] INT NULL, 
    [FamilyMemberID] INT NULL, 
    CONSTRAINT [FK_tblFamilyHistory_tblUsernames] FOREIGN KEY ([UserID]) REFERENCES [tblUsernames]([Id]),
    CONSTRAINT [FK_tlbFamilyHistory_tblFamilyMembers] FOREIGN KEY ([FamilyMemberID]) REFERENCES [tblFamilyMembers]([Id])
)
