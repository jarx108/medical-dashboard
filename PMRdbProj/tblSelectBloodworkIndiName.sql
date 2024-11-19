CREATE TABLE [dbo].[tblSelectBloodworkIndiName]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [BloodworkGroupNameID] INT NOT NULL, 
    [Name] VARCHAR(50) NOT NULL, 
    [RangeLower] INT NULL, 
    [RangeUpper] INT NULL, 
    [UnitMeasure] NCHAR(10) NULL, 
    [Notes] VARCHAR(MAX) NULL, 
    CONSTRAINT [FK_tblSelectBloodworkIndiName_tblSelectBloodworkGroupName] FOREIGN KEY ([BloodworkGroupNameID]) REFERENCES [tblSelectBloodworkGroupName]([Id])
)
