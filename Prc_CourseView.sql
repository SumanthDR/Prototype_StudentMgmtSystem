USE [dbclg]
GO
/****** Object:  StoredProcedure [dbo].[Prc_CourseView]    Script Date: 01-07-2020 19:55:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Prc_CourseView]
as
begin
select Course_Id,Course_Code,Course_Name,Course_Descript from Tbl_Course
end
