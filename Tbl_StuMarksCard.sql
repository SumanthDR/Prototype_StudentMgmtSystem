USE [dbclg]
GO

/****** Object:  Table [dbo].[Tbl_StuMarksCard]    Script Date: 2/27/2020 12:14:53 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Tbl_StuMarksCard](
	[SlNo] [int] NOT NULL,
	[RegNo] [varchar](50) NULL,
	[Stu_Name] [varchar](50) NULL,
	[Course_Id] [int] NULL,
	[Course_Name] [varchar](50) NULL,
	[Semester] [varchar](50) NULL,
	[Subject_Id] [int] NULL,
	[Subject_Name] [varchar](50) NULL,
	[Th_Max] [int] NULL,
	[Th_Min] [int] NULL,
	[Th_Sec] [int] NULL,
	[IA_Max] [int] NULL,
	[IA_Min] [int] NULL,
	[IA_Sec] [int] NULL,
	[Total_Max] [int] NULL,
	[Total_Sec] [int] NULL,
	[Result] [varchar](50) NULL,
	[Remarks] [int] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

