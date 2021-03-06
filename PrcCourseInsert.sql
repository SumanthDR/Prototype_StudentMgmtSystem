USE [dbclg]
GO
/****** Object:  StoredProcedure [dbo].[PrcCourseInsert]    Script Date: 28-06-2020 09:16:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[PrcCourseInsert]
(
	@Course_Code varchar(50),
	@Course_Name varchar(50),
	@Course_Descript text,
	@Course_Date date,
	@ERROR varchar(100) out 
)
as
if exists(select Course_Code,Course_Name from Tbl_Course where Course_Code=@Course_Code or Course_Name=@Course_Name)
begin 
set @ERROR='Course Code or Course Name Already Exists.'
end
else
begin
insert into dbo.Tbl_Course values(@Course_Code,@Course_Name,@Course_Descript,@Course_Date,1);
set @ERROR=@Course_Name+' Saved Successfully.'
end
