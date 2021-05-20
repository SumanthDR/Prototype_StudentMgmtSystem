alter Procedure Prc_FetchCrsLang
(
	@regno varchar(50)
)
as
begin
select Tbl_StuRegister.StuName,Tbl_StuRegister.CourseId,Tbl_Course.Course_Name, Tbl_StuRegister.ILangId,Tbl_Subject.Sub_Name from Tbl_StuRegister,Tbl_Course,Tbl_Subject
where RegNo like @regno and Tbl_Course.Course_Id=Tbl_StuRegister.CourseId and Tbl_Subject.Sub_Id=Tbl_StuRegister.ILangId
end
go


