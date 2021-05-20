USE [dbclg]
GO
/****** Object:  StoredProcedure [dbo].[PrcSubInsert1]    Script Date: 2/25/2020 11:01:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[PrcSubInsert1]
(
	@Sub_Name text,
	@Sub_Descript text,
	@Sub_Category text,
	@Sub_th_Max int,
	@Sub_th_Min int,
	@Sub_IA_Max int,
	@Sub_IA_Min int,
	@Sub_Sum_th_IA int,
	@Sub_Ins_Date date,
	@Course_Id int
)
as
begin
insert into dbo.Tbl_Subject values(@Sub_Name,@Sub_Descript,@Sub_Category,@Sub_th_Max,@Sub_th_Min,@Sub_IA_Max,@Sub_IA_Min,@Sub_Ins_Date,1,@Sub_Sum_th_IA,@Course_Id);
end


