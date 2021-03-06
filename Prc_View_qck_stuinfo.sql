USE [dbclg]
GO
/****** Object:  StoredProcedure [dbo].[Prc_View_qck_stuinfo]    Script Date: 25-01-2021 21:28:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Prc_View_qck_stuinfo]
(
	@para varchar(50)
)
as
begin
select distinct RegNo,StuName,Gender,DOB,
AadhaarNo,Course_Name,FName,FPhNo,
m.Semester,m.Max_Marks,m.G_Total,m.SGPA,
m.Final_Result
from Tbl_StuRegister s 
left join Tbl_Course c on s.CourseId=c.Course_Id
left join Tbl_StuMarksCard m on m.stu_id=s.StuId
where
RegNo=@para 
end


