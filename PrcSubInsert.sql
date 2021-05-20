create procedure PrcSubInsert
(
	@CrsId int,
	@Sub_Name text,
	@Sub_Descript text,
	@Sub_th_Max int,
	@Sub_th_Min int,
	@Sub_IA_Max int,
	@Sub_IA_Min int,
	@Sub_Ins_Date date
)
as
begin
insert into dbo.Tbl_Subject values(@CrsId,@Sub_Name,@Sub_Descript,@Sub_th_Max,@Sub_th_Min,@Sub_IA_Max,@Sub_IA_Min,@Sub_Ins_Date,1);
end
go