USE [dbclg]
GO

/****** Object:  Table [dbo].[Tbl_StuRegister]    Script Date: 2/27/2020 12:15:09 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Tbl_StuRegister](
	[SlNo] [int] IDENTITY(1,1) NOT NULL,
	[RegNo] [varchar](50) NULL,
	[AadharNo] [varchar](50) NULL,
	[Name] [varchar](50) NULL,
	[Fname] [varchar](50) NULL,
	[Gender] [varchar](50) NULL,
	[Mobile1] [varchar](50) NULL,
	[Mobile2] [varchar](50) NULL,
	[Course_Id] [int] NULL,
	[Language_Id] [int] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

