USE [dbclg]
GO
/****** Object:  StoredProcedure [dbo].[Prc_MarksCard_Update]    Script Date: 26-01-2021 11:27:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Prc_MarksCard_Update]
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
update Tbl_StuMarksCard 
set 
	Course_Id=@Course_Id
	,Semester=@Semester
	,Subject_Id=@Subject_Id
	,Th_Sec=@Th_Sec
	,IA_Sec=@IA_Sec
	,Total_Sec=@Total_Sec
	,Result=@Result
	,Year=@Year
	,G_Total=@G_Total
	,SGPA=@SGPA
	,Final_Result=@Final_Result
	,Percentage=@Percentage
	,Max_Marks=@Max_Marks
	where stu_id=@stu_id 
	and Semester=@Semester
	and Subject_Id=@Subject_Id;
    set @ERROR='Marks updated effectively.';
end