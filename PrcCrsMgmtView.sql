USE [dbclg]
GO
/****** Object:  StoredProcedure [dbo].[PrcCrsMgmtView]    Script Date: 12/18/2019 10:36:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[PrcCrsMgmtView]
as
begin
select Course_Name as Course ,Sub_Name as Subjects,Semester as Semester from Tbl_Course c,Tbl_Subject s,Tbl_Mapping m where c.Course_Id=m.Cours_Id and s.Sub_Id=m.Subject_Id order by Course_Name
end



