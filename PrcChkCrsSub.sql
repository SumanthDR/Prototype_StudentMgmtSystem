USE [dbclg]
GO
/****** Object:  StoredProcedure [dbo].[PrcChkCrsSub]    Script Date: 03-07-2020 07:16:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[PrcChkCrsSub]
(
	@Crs_Id int
)
as
begin 
select s.Sub_Name ,s.Sub_Id,s.Crs_Id from Tbl_Subject s,Tbl_Course c where Sub_IsActive=1 and s.Crs_Id=c.Course_Id and s.Crs_Id=@Crs_Id
end


