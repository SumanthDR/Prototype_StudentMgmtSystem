USE [dbclg]
GO
/****** Object:  StoredProcedure [dbo].[Prc_MarksCard_Inser]    Script Date: 26-01-2021 10:25:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Prc_MarksCard_Inser]
(
	@stu_id int,
	@Course_Id int,
	@Semester varchar(50),
	@Subject_Id int,
	@Th_Sec int,
	@IA_Sec int,
	@Total_Sec int,
	@Result varchar(50),
	@Year varchar(50),
	@Max_Marks int,
	@G_Total int,
	@SGPA float,
	@Final_Result varchar(50),
	@Percentage float,	
	@ERROR varchar(100) OUT
)
as
begin
insert into Tbl_StuMarksCard
values
(
	@stu_id,@Course_Id,@Semester,@Subject_Id,
	@Th_Sec,@IA_Sec,@Total_Sec,@Result,@Year,
	@Max_Marks,@G_Total,@SGPA,@Final_Result,@Percentage
)
set @ERROR='Marks saved successfully.';
end

