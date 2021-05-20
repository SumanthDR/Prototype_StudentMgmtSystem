alter procedure PrcComboLang
(
	@CourseId int
)
as
begin
select Sub_Id as keys,Sub_Name as value from Tbl_Subject where Sub_Category like 'I Language' and Crs_Id=@CourseId
end
