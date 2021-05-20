alter procedure Prc_RegisterStuUpdate
(
	@stu_id varchar(50),
	@regno varchar(50),
	@stuname varchar(60),
	@dob date,
	@gender  varchar(50),
	@aadhaarno varchar(50),
	@stuphno varchar(50),
	@stuemail varchar(60),
	@fname varchar(50),
	@fphno varchar(50),
	@femail varchar(50),
	@courseid int,
	@langid int,
	@ERROR varchar(100) out
)
as
if exists(select RegNo,AadhaarNo,StuPhNo from Tbl_StuRegister where StuId!=@stu_id and (RegNo=@regno or AadhaarNo=@aadhaarno or StuPhNo=@stuphno))
begin
set @ERROR='Register No. OR Aadhaar No. OR Phone No. already exists.'
end
else
begin
update Tbl_StuRegister set RegNo=@regno,
							StuName=@stuname,
							DOB=@dob,
							Gender=@gender,
							AadhaarNo=@aadhaarno,
							StuPhNo=@stuphno,
							StuEmail=@stuemail,
							FName=@fname,
							FPhNo=@fphno,
							FEmail=@femail,
							CourseId=@courseid,
							ILangId=@langid
							where StuId=@stu_id
set @ERROR='Record updated successfully.'
end
go



