USE [dbclg]
GO

/****** Object:  Table [dbo].[Tbl_StuInfo]    Script Date: 2/27/2020 12:14:17 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Tbl_StuInfo](
	[SlNo] [int] IDENTITY(1,1) NOT NULL,
	[Regno] [varchar](50) NOT NULL,
	[name] [varchar](50) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

