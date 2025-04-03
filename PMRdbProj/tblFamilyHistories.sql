CREATE TABLE [dbo].[tblFamilyHistories](
	[FamilyHistoryId] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[SelectFamilyMemberID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[FamilyHistoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblFamilyHistories]  WITH CHECK ADD  CONSTRAINT [FK_tblFamilyHistories_tblFamilyMembers] FOREIGN KEY([SelectFamilyMemberID])
REFERENCES [dbo].[tblSelectFamilyMembers] ([SelectFamilyMemberId])
GO

ALTER TABLE [dbo].[tblFamilyHistories] CHECK CONSTRAINT [FK_tblFamilyHistories_tblFamilyMembers]
GO


GO
ALTER TABLE [dbo].[tblFamilyHistories]  WITH CHECK ADD  CONSTRAINT [FK_tblFamilyHistories_tblUsers] FOREIGN KEY([UserID])
REFERENCES [dbo].[tblUsers] ([UserId])
GO

ALTER TABLE [dbo].[tblFamilyHistories] CHECK CONSTRAINT [FK_tblFamilyHistories_tblUsers]
GO

