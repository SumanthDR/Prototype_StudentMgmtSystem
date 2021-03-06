USE [dbclg]
GO
/****** Object:  StoredProcedure [dbo].[Prc_ViewStu_Marks_AllSem]    Script Date: 13-01-2021 12:39:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Prc_ViewStu_Marks_AllSem]
(
	@Courseid int,
	@Year varchar(50),
	@Result varchar(50),
	@Semester varchar(50)
)
as
if @Result!='' and @Semester=''
begin
SELECT
		[stu_id]
		,[RegNo]
		,[StuName]
		,[Course_Name]
		,[I]
		,[II]
		,[III]
		,[IV]
		,[V]
		,[VI]
FROM
(
	select distinct
	t1.stu_id
	,t2.RegNo
	,t2.StuName
	,t3.Course_Name
	,t1.Semester
	,t1.Final_Result
	from Tbl_StuMarksCard t1 left join Tbl_StuRegister t2
	on t1.stu_id=t2.StuId 
	inner join Tbl_Course t3 on t3.Course_Id=t2.CourseId
	where t1.Course_Id=@Courseid and t2.RegNo like @Year+'%'
	and Final_Result=@Result
)AS Src
PIVOT
(
	min(Final_Result)
	FOR[Semester] IN ([I],[II],[III],[IV],[V],[VI])
)AS Pvt
end
else if @Semester!='' and @Result=''
begin
select distinct
	t1.stu_id
	,t2.RegNo
	,t2.StuName
	,t3.Course_Name
	,t1.Semester
	,t1.Max_Marks	
	,t1.G_Total
	,t1.Percentage
	,t1.Final_Result	
	from Tbl_StuMarksCard t1 left join Tbl_StuRegister t2
	on t1.stu_id=t2.StuId 
	inner join Tbl_Course t3 on t3.Course_Id=t2.CourseId
	where t1.Course_Id=@Courseid and t2.RegNo like @Year+'%' and
	t1.Semester=@Semester;
end
else if @Semester!='' and @Result!=''
begin
select distinct
	t1.stu_id
	,t2.RegNo
	,t2.StuName
	,t3.Course_Name
	,t1.Semester
	,t1.Max_Marks	
	,t1.G_Total
	,t1.Percentage
	,t1.Final_Result	
	from Tbl_StuMarksCard t1 left join Tbl_StuRegister t2
	on t1.stu_id=t2.StuId 
	inner join Tbl_Course t3 on t3.Course_Id=t2.CourseId
	where t1.Course_Id=@Courseid and t2.RegNo like @Year+'%' and
	t1.Semester=@Semester and Final_Result=@Result;
end
else 
begin
SELECT
		[stu_id]
		,[RegNo]
		,[StuName]
		,[Course_Name]
		,[I]
		,[II]
		,[III]
		,[IV]
		,[V]
		,[VI]
FROM
(
	select distinct
	t1.stu_id
	,t2.RegNo
	,t2.StuName
	,t3.Course_Name
	,t1.Semester
	,t1.Final_Result
	from Tbl_StuMarksCard t1 left join Tbl_StuRegister t2
	on t1.stu_id=t2.StuId 
	inner join Tbl_Course t3 on t3.Course_Id=t2.CourseId
	where t1.Course_Id=@Courseid and t2.RegNo like @Year+'%'
)AS Src
PIVOT
(
	min(Final_Result)
	FOR[Semester] IN ([I],[II],[III],[IV],[V],[VI])
)AS Pvt
end
