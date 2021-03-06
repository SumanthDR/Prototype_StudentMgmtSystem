USE [dbclg]
GO
/****** Object:  StoredProcedure [dbo].[Prc_ViewSemMarks]    Script Date: 14-01-2021 14:59:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Prc_ViewSemMarks]
(
	@course_id int,
	@semester varchar(50),
	@regno varchar(50),
	@ERROR varchar(100) OUT
)
as
if exists(select distinct m.stu_id,s.RegNo from Tbl_StuMarksCard m, Tbl_StuRegister s  where m.stu_id =s.StuId and m.Semester=@semester and s.RegNo=@regno)
begin
set @ERROR='Marks already exists. To update Goto -> Report Card -> View Marks -> Update '
end
else
begin
select distinct Sub_Id,Sub_Name,Cours_Id,Semester,Sub_th_Max,Sub_th_Min,Sub_IA_Max,Sub_IA_Min,Sub_Id,StuId from Tbl_Subject s,Tbl_Mapping m,Tbl_Course c,Tbl_StuRegister where 
m.Cours_Id=c.Course_Id and m.Cours_Id=@course_id and s.Sub_Id=m.Subject_Id and m.Semester=@semester and s.Sub_Category not like 'Susidiary (Not Added To Total Marks)' and
(s.Sub_Category not like 'I Language' or (Tbl_StuRegister.RegNo=@regno and Tbl_StuRegister.ILangId=s.Sub_Id)) and Tbl_StuRegister.RegNo=@regno
set @ERROR='New Entry, Please fill all feilds :)'
end




