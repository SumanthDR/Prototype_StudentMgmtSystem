USE [dbclg]
GO
/****** Object:  StoredProcedure [dbo].[Prc_ViewSubsidairy]    Script Date: 21-01-2021 10:38:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Prc_ViewSubsidairy]
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
select distinct Sub_Id,Sub_Name,Cours_Id,Semester,Sub_th_Max,Sub_th_Min,Sub_IA_Max,Sub_IA_Min,StuId from Tbl_Subject s,Tbl_Mapping m,Tbl_Course c,Tbl_StuRegister where 
m.Cours_Id=@course_id and m.Semester=@semester and m.Subject_Id=s.Sub_Id and
(s.Sub_Category like 'Susidiary (Not Added To Total Marks)' and (Tbl_StuRegister.RegNo=@regno) )
set @ERROR='New Entry, Please fill all feilds :)'
end

