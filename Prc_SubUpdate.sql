alter procedure Prc_SubUpdate
(
	@Sub_Id int,
	@Sub_Code varchar(50),
	@Sub_Name varchar(50),
	@Sub_Descript text,
	@Sub_Category text,
	@Sub_th_Max int,
	@Sub_th_Min int,
	@Sub_IA_Max int,
	@Sub_IA_Min int,
	@Sub_Sum_th_IA int,
	@Sub_Ins_Date date,
	@Course_Id int,
	@ERROR varchar(100) out
)
as
begin
update Tbl_Subject set Sub_Code=@Sub_Code,
						Sub_Name=@Sub_Name,
						Sub_Descript=@Sub_Descript,
						Sub_Category=@Sub_Category,
						Sub_th_Max=@Sub_th_Max,
						Sub_th_Min=@Sub_th_Min,
						Sub_IA_Max=@Sub_IA_Max,
						Sub_IA_Min=@Sub_IA_Min,
						Sub_Sum_th_IA=@Sub_Sum_th_IA,
						Sub_Ins_Date=@Sub_Ins_Date,
						Crs_Id=@Course_Id
						where Sub_Id=@Sub_Id
						set @ERROR=' Saved Successfully.'
end
go
