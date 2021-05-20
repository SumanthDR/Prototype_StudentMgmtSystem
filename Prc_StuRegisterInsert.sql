create procedure Prc_StuRegisterInsert
(
	@regno varchar(50),
	@aadhaarno varchar(50),
	@name varchar(50),
	@fname varchar(50),
	@gender varchar(50),
	@mobile1 varchar(50),
	@mobile2 varchar(50),
	@course_id int,
	@lang_id int
)
as
begin
insert into Tbl_StuRegister values
(
	@regno ,
	@aadhaarno ,
	@name ,
	@fname ,
	@gender ,
	@mobile1 ,
	@mobile2 ,
	@course_id ,
	@lang_id 
)
end
go