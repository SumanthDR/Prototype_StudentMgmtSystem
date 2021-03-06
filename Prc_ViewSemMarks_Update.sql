USE [dbclg]
GO
/****** Object:  StoredProcedure [dbo].[Prc_ViewSemMarks_Update]    Script Date: 15-01-2021 11:28:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Prc_ViewSemMarks_Update]
(
	@course_id int,
	@semester varchar(50),
	@regno varchar(50),
	@ERROR varchar(100) OUT
)
as
begin
select m.stu_id,r.RegNo,r.StuName,m.Course_Id as CourseId,m.Subject_Id,s.Sub_Name,s.Sub_th_Max,s.Sub_th_Min,
		m.Th_Sec,s.Sub_IA_Max,s.Sub_IA_Min,m.IA_Sec,s.Sub_Sum_th_IA,m.Total_Sec,m.Result,m.Year,
		m.Percentage,m.SGPA,m.G_Total,m.Final_Result,m.Semester,c.Course_Name
		from Tbl_StuRegister r left join Tbl_StuMarksCard m on m.stu_id=r.StuId 
		inner join Tbl_Subject s on m.Subject_Id=s.Sub_Id inner join Tbl_Course c on 
		c.Course_Id=s.Crs_Id
		where 
		r.RegNo=@regno and Semester=@semester and 
		s.Sub_Category not like('Susidiary (Not Added To Total Marks)')
		order by s.Sub_th_Max 
set @ERROR='Update marks or Year :)'
end




