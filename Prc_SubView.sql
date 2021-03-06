USE [dbclg]
GO
/****** Object:  StoredProcedure [dbo].[Prc_SubView]    Script Date: 01-07-2020 13:44:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Prc_SubView]
(
	@Parameter varchar(50),
	@flag int
)
as

/** Sort subject according to there course ******/
if(@flag=1)
begin
select Sub_Id,Sub_Code,Sub_Name,Sub_Descript,Sub_Category,Crs_Id,Course_Code,Course_Name,Sub_th_Max,Sub_th_Min,Sub_IA_Max,Sub_IA_Min from Tbl_Subject s,Tbl_Course c where Crs_Id=@Parameter and s.Crs_Id=c.Course_Id
end
/** Search subject according to there Subject Code ******/
else if @flag=2
begin
select Sub_Id,Sub_Code,Sub_Name,Sub_Descript,Sub_Category,Crs_Id,Course_Code,Course_Name,Sub_th_Max,Sub_th_Min,Sub_IA_Max,Sub_IA_Min from Tbl_Subject s,Tbl_Course c where Sub_Code=@Parameter and s.Crs_Id=c.Course_Id
end


