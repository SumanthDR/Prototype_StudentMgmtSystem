create procedure PrcComboSub
as
begin 
select Course_Id, Course_Name from dbo.Tbl_Course where Course_IsActive=1;
end
go

