USE [dbclg]
GO
/****** Object:  StoredProcedure [dbo].[Prc_CourseUpdate]    Script Date: 28-06-2020 09:45:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Prc_CourseUpdate]
(
	@Course_Id int,
	@Course_Code varchar(50),
	@Course_Name varchar(50),
	@Course_Descript text,
	@Course_Date date
)
as
begin
update Tbl_Course set Course_Code=@Course_Code,Course_Name=@Course_Name,Course_Descript=@Course_Descript,Course_Date=@Course_Date where Course_Id=@Course_Id
end