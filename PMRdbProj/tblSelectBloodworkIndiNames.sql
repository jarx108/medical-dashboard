CREATE TABLE [dbo].[tblSelectBloodworkIndiNames](
	[SelectBloodworkIndiNameId] [int] IDENTITY(1,1) NOT NULL,
	[SelectBloodworkGroupNameID] [int] NOT NULL,
	[DetailedName] [varchar](50) NOT NULL,
	[RangeLower] [int] NULL,
	[RangeUpper] [int] NULL,
	[UnitMeasure] [nchar](10) NULL,
	[Notes] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[SelectBloodworkIndiNameId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblSelectBloodworkIndiNames]  WITH CHECK ADD  CONSTRAINT [FK_tblSelectBloodworkIndiNames_tblSelectBloodworkGroupNames] FOREIGN KEY([SelectBloodworkGroupNameID])
REFERENCES [dbo].[tblSelectBloodworkGroupNames] ([SelectBloodworkGroupNameId])
GO

ALTER TABLE [dbo].[tblSelectBloodworkIndiNames] CHECK CONSTRAINT [FK_tblSelectBloodworkIndiNames_tblSelectBloodworkGroupNames]
GO

