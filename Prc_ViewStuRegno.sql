USE [dbclg]
GO
/****** Object:  StoredProcedure [dbo].[Prc_ViewStuRegno]    Script Date: 11-07-2020 10:58:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Prc_ViewStuRegno]
(
	@RegNo varchar(50)
)
as
begin
select distinct Tbl_StuRegister.StuId,Tbl_StuRegister.RegNo,Tbl_StuRegister.StuName,Tbl_StuRegister.DOB,Tbl_StuRegister.Gender,Tbl_StuRegister.AadhaarNo,
Tbl_StuRegister.StuPhNo,Tbl_StuRegister.StuEmail,Tbl_StuRegister.FName,Tbl_StuRegister.FPhNo,Tbl_StuRegister.FEmail,Tbl_StuRegister.CourseId,Tbl_StuRegister.ILangId,
Tbl_Course.Course_Name,Tbl_Subject.Sub_Name from Tbl_StuRegister,Tbl_Course,Tbl_Subject where Tbl_StuRegister.RegNo=@RegNo and Tbl_Course.Course_Id=Tbl_StuRegister.CourseId 
and Tbl_Subject.Sub_Id=Tbl_StuRegister.ILangId
end


