USE [dbclg]
GO

/****** Object:  Table [dbo].[Tbl_Course]    Script Date: 2/27/2020 12:13:15 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Tbl_Course](
	[Course_Id] [int] IDENTITY(1,1) NOT NULL,
	[Course_Name] [varchar](50) NULL,
	[Course_Descript] [text] NULL,
	[Course_Date] [date] NULL,
	[Course_IsActive] [int] NULL,
 CONSTRAINT [PK_Tbl_Course] PRIMARY KEY CLUSTERED 
(
	[Course_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

