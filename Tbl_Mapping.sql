USE [dbclg]
GO

/****** Object:  Table [dbo].[Tbl_Mapping]    Script Date: 2/27/2020 12:13:29 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Tbl_Mapping](
	[Map_Id] [int] IDENTITY(1,1) NOT NULL,
	[Cours_Id] [int] NULL,
	[Subject_Id] [int] NULL,
	[Semester] [varchar](50) NULL,
	[MapDate] [date] NULL,
 CONSTRAINT [PK_Tbl_Mapping] PRIMARY KEY CLUSTERED 
(
	[Map_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

