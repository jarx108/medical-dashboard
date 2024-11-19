CREATE TABLE [dbo].[tblVaccines]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserID] INT NOT NULL, 
    [NumDoses] INT NULL, 
    [LastDose] DATE NULL, 
    CONSTRAINT [FK_tblVaccines_tblUsernames] FOREIGN KEY ([UserID]) REFERENCES [tblUsernames]([Id])
)
