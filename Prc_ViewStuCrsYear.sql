alter procedure Prc_ViewStuCrsYear
(
	@CourseId varchar(50),
	@Year varchar(50)
)
as
begin
select distinct Tbl_StuRegister.StuId,Tbl_StuRegister.RegNo,Tbl_StuRegister.StuName,
				Tbl_StuRegister.DOB,Tbl_StuRegister.Gender,Tbl_StuRegister.AadhaarNo,
					Tbl_StuRegister.StuPhNo,Tbl_StuRegister.StuEmail,
					Tbl_StuRegister.FName,Tbl_StuRegister.FPhNo,Tbl_StuRegister.FEmail,
					Tbl_StuRegister.CourseId,Tbl_StuRegister.ILangId,
					Tbl_Course.Course_Name,Tbl_Subject.Sub_Name 
					from Tbl_StuRegister,Tbl_Course,Tbl_Subject 
					where Tbl_Subject.Sub_Id=Tbl_StuRegister.ILangId
						and Tbl_StuRegister.CourseId=Tbl_Course.Course_Id and Tbl_StuRegister.CourseId=@CourseId
						and Tbl_StuRegister.RegNo like @Year + '%'
end




