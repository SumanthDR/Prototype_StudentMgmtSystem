create procedure Prc_RegisterStu
(
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
if exists(select RegNo,AadhaarNo,StuPhNo from Tbl_StuRegister where RegNo=@regno or AadhaarNo=@aadhaarno or StuPhNo=@stuphno)
begin
set @ERROR='Register No. OR Aadhaar No. OR Phone No. already exists.'
end
else
begin
insert into Tbl_StuRegister values (@regno,@stuname,@dob,@gender,@aadhaarno,@stuphno,@stuemail,@fname,@fphno,@femail,@courseid,@langid)
set @ERROR= @stuname +'s'+' record saved successfully.'
end
go


