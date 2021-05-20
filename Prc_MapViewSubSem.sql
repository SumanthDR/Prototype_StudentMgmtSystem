USE [dbclg]
GO
/****** Object:  StoredProcedure [dbo].[PrcMarksCard]    Script Date: 13-07-2020 11:45:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Prc_MapViewSubSem]
(
	@Crs_id int,
	@Sem varchar(50)
)
as
begin
select Map_Id,Sub_Id,Sub_Name,Cours_Id,Course_Name,Semester from Tbl_Subject s,Tbl_Mapping m,Tbl_Course c where m.Cours_Id=c.Course_Id and m.Cours_Id=@Crs_id and s.Sub_Id=m.Subject_Id and m.Semester=@Sem
end




