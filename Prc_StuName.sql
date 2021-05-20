create procedure Prc_StuName
(
	@regno varchar(50)
)
as
begin 
select name from Tbl_StuInfo where Regno like @regno
end
go