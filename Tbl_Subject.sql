USE [dbclg]
GO

/****** Object:  Table [dbo].[Tbl_Subject]    Script Date: 2/27/2020 12:15:23 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tbl_Subject](
	[Sub_Id] [int] IDENTITY(1,1) NOT NULL,
	[Sub_Name] [text] NULL,
	[Sub_Descript] [text] NULL,
	[Sub_Category] [text] NULL,
	[Sub_th_Max] [int] NULL,
	[Sub_th_Min] [int] NULL,
	[Sub_IA_Max] [int] NULL,
	[Sub_IA_Min] [int] NULL,
	[Sub_Ins_Date] [date] NULL,
	[Sub_IsActive] [int] NULL,
	[Sub_Sum_th_IA] [int] NULL,
	[Crs_Id] [int] NULL,
 CONSTRAINT [PK_Tbl_Subject] PRIMARY KEY CLUSTERED 
(
	[Sub_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

