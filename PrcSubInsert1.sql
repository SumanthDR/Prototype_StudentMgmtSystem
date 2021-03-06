USE [dbclg]
GO
/****** Object:  StoredProcedure [dbo].[PrcSubInsert1]    Script Date: 29-06-2020 12:24:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[PrcSubInsert1]
(
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
if exists(select Sub_Code,Sub_Name,Crs_Id from Tbl_Subject where (Crs_Id=@Course_Id and Sub_Code=@Sub_Code) or (Crs_Id=@Course_Id and Sub_Name=@Sub_Name))
begin 
set @ERROR='Subject Code or Subject Name Already Exists for this course.'
end
else
begin
insert into dbo.Tbl_Subject values(@Sub_Code,@Sub_Name,@Sub_Descript,@Sub_Category,@Sub_th_Max,@Sub_th_Min,@Sub_IA_Max,@Sub_IA_Min,@Sub_Ins_Date,1,@Sub_Sum_th_IA,@Course_Id);
set @ERROR=' Saved Successfully.'
end

