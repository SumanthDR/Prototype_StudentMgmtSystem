USE [dbclg]
GO
/****** Object:  StoredProcedure [dbo].[PrcMarksCard]    Script Date: 2/12/2020 8:38:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[PrcMarksCard]
(
	@Crs_id int,
	@Sem varchar(50)
)
as
begin
select Sub_Id,Sub_Name as Subjects,Sub_th_Max,Sub_th_Min,Sub_IA_Max,Sub_IA_Min,Sub_Sum_th_IA from Tbl_Subject s,Tbl_Mapping m,Tbl_Course c where m.Cours_Id=c.Course_Id and m.Cours_Id=@Crs_id and s.Sub_Id=m.Subject_Id and m.Semester=@Sem
end
