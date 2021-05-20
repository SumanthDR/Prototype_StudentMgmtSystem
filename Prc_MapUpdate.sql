alter procedure Prc_MapUpdate
(
	@Map_Id int,
	@Cours_Id int,
	@Subject_Id int,
	@Semester varchar(50),
	@MapDate date
)
as
begin
update Tbl_Mapping set Cours_Id=@Cours_Id,Subject_Id=@Subject_Id,Semester=@Semester,MapDate=@MapDate where Map_Id=@Map_Id
end
go

