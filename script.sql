USE [master]
GO
/****** Object:  Database [dbclg]    Script Date: 05-03-2021 22:00:27 ******/
CREATE DATABASE [dbclg]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbclg', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\dbclg.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dbclg_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\dbclg_log.ldf' , SIZE = 1536KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [dbclg] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbclg].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbclg] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbclg] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbclg] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbclg] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbclg] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbclg] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [dbclg] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbclg] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbclg] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbclg] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbclg] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbclg] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbclg] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbclg] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbclg] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbclg] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbclg] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbclg] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbclg] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbclg] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbclg] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbclg] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbclg] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbclg] SET  MULTI_USER 
GO
ALTER DATABASE [dbclg] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbclg] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbclg] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbclg] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [dbclg] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dbclg] SET QUERY_STORE = OFF
GO
USE [dbclg]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [dbclg]
GO
/****** Object:  Table [dbo].[Tbl_Course]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Course](
	[Course_Id] [int] IDENTITY(1,1) NOT NULL,
	[Course_Code] [varchar](50) NOT NULL,
	[Course_Name] [varchar](50) NULL,
	[Course_Descript] [text] NULL,
	[Course_Date] [date] NULL,
	[Course_IsActive] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Course_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Mapping]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Mapping](
	[Map_Id] [int] IDENTITY(1,1) NOT NULL,
	[Cours_Id] [int] NOT NULL,
	[Subject_Id] [int] NOT NULL,
	[Semester] [varchar](50) NOT NULL,
	[MapDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[Map_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_StuMarksCard]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_StuMarksCard](
	[Card_Id] [int] IDENTITY(1,1) NOT NULL,
	[stu_id] [int] NOT NULL,
	[Course_Id] [int] NOT NULL,
	[Semester] [varchar](max) NOT NULL,
	[Subject_Id] [int] NOT NULL,
	[Th_Sec] [float] NOT NULL,
	[IA_Sec] [float] NOT NULL,
	[Total_Sec] [float] NOT NULL,
	[Result] [varchar](max) NOT NULL,
	[Year] [varchar](max) NOT NULL,
	[Max_Marks] [float] NOT NULL,
	[G_Total] [float] NOT NULL,
	[SGPA] [float] NOT NULL,
	[Final_Result] [varchar](max) NOT NULL,
	[Percentage] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Card_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_StuRegister]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_StuRegister](
	[StuId] [int] IDENTITY(1,1) NOT NULL,
	[RegNo] [nvarchar](255) NOT NULL,
	[StuName] [nvarchar](255) NOT NULL,
	[DOB] [datetime] NOT NULL,
	[Gender] [nvarchar](255) NOT NULL,
	[AadhaarNo] [float] NULL,
	[StuPhNo] [float] NULL,
	[StuEmail] [nvarchar](255) NULL,
	[FName] [nvarchar](255) NOT NULL,
	[FPhNo] [float] NOT NULL,
	[FEmail] [nvarchar](255) NULL,
	[CourseId] [int] NOT NULL,
	[ILangId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[StuId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Subject]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Subject](
	[Sub_Id] [int] IDENTITY(1,1) NOT NULL,
	[Sub_Code] [varchar](50) NOT NULL,
	[Sub_Name] [varchar](50) NULL,
	[Sub_Descript] [text] NULL,
	[Sub_Category] [text] NOT NULL,
	[Sub_th_Max] [int] NOT NULL,
	[Sub_th_Min] [int] NOT NULL,
	[Sub_IA_Max] [int] NOT NULL,
	[Sub_IA_Min] [int] NOT NULL,
	[Sub_Ins_Date] [date] NOT NULL,
	[Sub_IsActive] [int] NULL,
	[Sub_Sum_th_IA] [int] NOT NULL,
	[Crs_Id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Sub_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [StuName_index]    Script Date: 05-03-2021 22:00:27 ******/
CREATE NONCLUSTERED INDEX [StuName_index] ON [dbo].[Tbl_StuRegister]
(
	[StuName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [StuName_Regno_index]    Script Date: 05-03-2021 22:00:27 ******/
CREATE NONCLUSTERED INDEX [StuName_Regno_index] ON [dbo].[Tbl_StuRegister]
(
	[StuName] ASC,
	[RegNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Tbl_Mapping]  WITH CHECK ADD FOREIGN KEY([Cours_Id])
REFERENCES [dbo].[Tbl_Course] ([Course_Id])
GO
ALTER TABLE [dbo].[Tbl_Mapping]  WITH CHECK ADD FOREIGN KEY([Subject_Id])
REFERENCES [dbo].[Tbl_Subject] ([Sub_Id])
GO
ALTER TABLE [dbo].[Tbl_StuMarksCard]  WITH CHECK ADD FOREIGN KEY([Course_Id])
REFERENCES [dbo].[Tbl_Course] ([Course_Id])
GO
ALTER TABLE [dbo].[Tbl_StuMarksCard]  WITH CHECK ADD FOREIGN KEY([stu_id])
REFERENCES [dbo].[Tbl_StuRegister] ([StuId])
GO
ALTER TABLE [dbo].[Tbl_StuMarksCard]  WITH CHECK ADD FOREIGN KEY([Subject_Id])
REFERENCES [dbo].[Tbl_Subject] ([Sub_Id])
GO
ALTER TABLE [dbo].[Tbl_StuRegister]  WITH CHECK ADD FOREIGN KEY([CourseId])
REFERENCES [dbo].[Tbl_Course] ([Course_Id])
GO
ALTER TABLE [dbo].[Tbl_StuRegister]  WITH CHECK ADD FOREIGN KEY([ILangId])
REFERENCES [dbo].[Tbl_Subject] ([Sub_Id])
GO
ALTER TABLE [dbo].[Tbl_Subject]  WITH CHECK ADD FOREIGN KEY([Crs_Id])
REFERENCES [dbo].[Tbl_Course] ([Course_Id])
GO
/****** Object:  StoredProcedure [dbo].[Prc_ComboSub]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Prc_ComboSub]
(
	@Course_id int
)
as
begin
select Course_Name as value,Course_Id as keys from dbo.Tbl_Course where Course_IsActive=1 and Course_Id=@Course_id;
end
GO
/****** Object:  StoredProcedure [dbo].[Prc_ComboSubView]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Prc_ComboSubView]
(
	@Course_id int
)
as
begin
select Course_Name as value,Course_Id as keys from dbo.Tbl_Course where Course_IsActive=1 and Course_Id=@Course_id;
end
GO
/****** Object:  StoredProcedure [dbo].[Prc_CourseUpdate]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Prc_CourseUpdate]
(
	@Course_Id int,
	@Course_Code varchar(50),
	@Course_Name varchar(50),
	@Course_Descript text,
	@Course_Date date
)
as
begin
update Tbl_Course set Course_Code=@Course_Code,Course_Name=@Course_Name,Course_Descript=@Course_Descript,Course_Date=@Course_Date where Course_Id=@Course_Id
end
GO
/****** Object:  StoredProcedure [dbo].[Prc_CourseView]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Prc_CourseView]
as
begin
select Course_Id,Course_Code,Course_Name,Course_Descript from Tbl_Course
end
GO
/****** Object:  StoredProcedure [dbo].[Prc_crs_search]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Prc_crs_search]
(
	@Course_Code varchar(50)
)
as
begin
select Course_Id,Course_Code,Course_Name,Course_Descript from Tbl_Course where Course_Code=@Course_Code
end
GO
/****** Object:  StoredProcedure [dbo].[Prc_FetchCrsLang]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[Prc_FetchCrsLang]
(
	@regno varchar(50)
)
as
begin
select Tbl_StuRegister.StuName,Tbl_StuRegister.CourseId,Tbl_Course.Course_Name, Tbl_StuRegister.ILangId,Tbl_Subject.Sub_Name from Tbl_StuRegister,Tbl_Course,Tbl_Subject
where RegNo like @regno and Tbl_Course.Course_Id=Tbl_StuRegister.CourseId and Tbl_Subject.Sub_Id=Tbl_StuRegister.ILangId
end
GO
/****** Object:  StoredProcedure [dbo].[Prc_MapUpdate]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Prc_MapUpdate]
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
GO
/****** Object:  StoredProcedure [dbo].[Prc_MapViewSubSem]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Prc_MapViewSubSem]
(
	@Crs_id int,
	@Sem varchar(50)
)
as
begin
/*select Map_Id,Sub_Id,Sub_Name,Cours_Id,Course_Name,Semester from Tbl_Subject s,Tbl_Mapping m,Tbl_Course c where m.Cours_Id=c.Course_Id and m.Cours_Id=@Crs_id and s.Sub_Id=m.Subject_Id and m.Semester=@Sem*/
select m.Map_Id,s.Crs_Id,s.Sub_Id,s.Sub_Name,s.Sub_Category,m.Semester from Tbl_Subject s join Tbl_Mapping m on m.Subject_Id=s.Sub_Id and m.Semester=@Sem and m.Cours_Id=@Crs_id
end



GO
/****** Object:  StoredProcedure [dbo].[Prc_MarksCard_Inser]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Prc_MarksCard_Inser]
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

GO
/****** Object:  StoredProcedure [dbo].[Prc_MarksCard_Update]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Prc_MarksCard_Update]
(
	@card_id int,
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
	 stu_id=@stu_id
	,Course_Id=@Course_Id
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
	where Card_Id=@card_id;
    set @ERROR='Marks updated effectively.';
end

GO
/****** Object:  StoredProcedure [dbo].[Prc_RegisterStu]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Prc_RegisterStu]
(
	@regno varchar(50),
	@stuname varchar(60),
	@dob date,
	@gender  varchar(50),
	@aadhaarno varchar(50),
	@stuphno varchar(50),
	@stuemail varchar(60),
	@fname varchar(50),
	@fphno varchar(50),
	@femail varchar(50),
	@courseid int,
	@langid int,
	@ERROR varchar(100) out
)
as
if exists(select RegNo,AadhaarNo,StuPhNo from Tbl_StuRegister where RegNo=@regno or AadhaarNo=@aadhaarno or StuPhNo=@stuphno)
begin
set @ERROR='Register No. OR Aadhaar No. OR Phone No. already exists.'
end
else
begin
insert into Tbl_StuRegister values (@regno,@stuname,@dob,@gender,@aadhaarno,@stuphno,@stuemail,@fname,@fphno,@femail,@courseid,@langid)
set @ERROR= @stuname +'s'+' record saved successfully.'
end
GO
/****** Object:  StoredProcedure [dbo].[Prc_RegisterStuUpdate]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Prc_RegisterStuUpdate]
(
	@stu_id varchar(50),
	@regno varchar(50),
	@stuname varchar(60),
	@dob date,
	@gender  varchar(50),
	@aadhaarno varchar(50),
	@stuphno varchar(50),
	@stuemail varchar(60),
	@fname varchar(50),
	@fphno varchar(50),
	@femail varchar(50),
	@courseid int,
	@langid int,
	@ERROR varchar(100) out
)
as
if exists(select RegNo,AadhaarNo,StuPhNo from Tbl_StuRegister where StuId!=@stu_id and (RegNo=@regno or AadhaarNo=@aadhaarno or StuPhNo=@stuphno))
begin
set @ERROR='Register No. OR Aadhaar No. OR Phone No. already exists.'
end
else
begin
update Tbl_StuRegister set RegNo=@regno,
							StuName=@stuname,
							DOB=@dob,
							Gender=@gender,
							AadhaarNo=@aadhaarno,
							StuPhNo=@stuphno,
							StuEmail=@stuemail,
							FName=@fname,
							FPhNo=@fphno,
							FEmail=@femail,
							CourseId=@courseid,
							ILangId=@langid
							where StuId=@stu_id
set @ERROR='Record updated successfully.'
end
GO
/****** Object:  StoredProcedure [dbo].[Prc_Search_Regno]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Prc_Search_Regno]
(
	@regno varchar(50)
)
as
begin/*
select distinct m.stu_id,s.RegNo,s.StuName,s.CourseId,c.Course_Name,m.Semester,m.SGPA
,m.Final_Result from Tbl_StuRegister s,Tbl_StuMarksCard m,Tbl_Course c where 
m.stu_id=s.StuId and s.RegNo=@regno and m.Course_Id=c.Course_Id

 select m.stu_id,r.RegNo,r.StuName,m.Course_Id as CourseId,m.Subject_Id,s.Sub_Name,s.Sub_th_Max,s.Sub_th_Min,
		m.Th_Sec,s.Sub_IA_Max,s.Sub_IA_Min,m.IA_Sec,s.Sub_Sum_th_IA,m.Total_Sec,m.Result,m.Year,
		m.Percentage,m.SGPA,m.G_Total,m.Final_Result,m.Semester
		from Tbl_StuRegister r left join Tbl_StuMarksCard m on m.stu_id=r.StuId 
		inner join Tbl_Subject s on m.Subject_Id=s.Sub_Id where r.RegNo=@regno order by Semester
*/
select distinct m.stu_id,m.Final_Result,m.Semester,m.SGPA,m.G_Total,m.Max_Marks,s.RegNo,
s.StuName,s.CourseId,c.Course_Name from Tbl_StuRegister s inner join Tbl_StuMarksCard m 
on m.stu_id=s.StuId inner join Tbl_Course c on m.Course_Id=c.Course_Id 
where s.RegNo=@regno order by Semester 

end
 




 


GO
/****** Object:  StoredProcedure [dbo].[Prc_Search_RegnoSem]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Prc_Search_RegnoSem]
(
	@regno varchar(50),
	@sem varchar(50)
)
as
begin
/*
select m.stu_id,r.RegNo,r.StuName,m.Course_Id as CourseId,m.Subject_Id,s.Sub_Name,s.Sub_th_Max,s.Sub_th_Min,m.Th_Sec,s.Sub_IA_Max,
s.Sub_IA_Min,m.IA_Sec,s.Sub_Sum_th_IA,m.Total_Sec,m.Result,m.Year
from Tbl_StuRegister r,Tbl_StuMarksCard m,Tbl_Subject s where m.stu_id=r.StuId 
and m.Subject_Id=s.Sub_Id and r.RegNo=@regno and Semester=@sem
*/
select m.stu_id,r.RegNo,r.StuName,m.Course_Id as CourseId,m.Subject_Id,s.Sub_Name,s.Sub_th_Max,s.Sub_th_Min,
		m.Th_Sec,s.Sub_IA_Max,s.Sub_IA_Min,m.IA_Sec,s.Sub_Sum_th_IA,m.Total_Sec,m.Result,m.Year,
		m.Percentage,m.SGPA,m.G_Total,m.Final_Result,m.Semester,c.Course_Name
		from Tbl_StuRegister r left join Tbl_StuMarksCard m on m.stu_id=r.StuId 
		inner join Tbl_Subject s on m.Subject_Id=s.Sub_Id inner join Tbl_Course c on 
		c.Course_Id=s.Crs_Id
		where r.RegNo=@regno and Semester=@sem order by s.Sub_th_Max 
end


GO
/****** Object:  StoredProcedure [dbo].[Prc_Search_Result]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Prc_Search_Result]
(
	@regno varchar(50),
	@result varchar(50)
)
as
if @result='FAIL'
begin
select m.stu_id,r.RegNo,r.StuName,m.Course_Id as CourseId,m.Subject_Id,s.Sub_Name,s.Sub_th_Max,s.Sub_th_Min,
		m.Th_Sec,s.Sub_IA_Max,s.Sub_IA_Min,m.IA_Sec,s.Sub_Sum_th_IA,m.Total_Sec,m.Result,m.Year,
		m.Percentage,m.SGPA,m.G_Total,m.Final_Result,m.Semester,c.Course_Name
		from Tbl_StuRegister r left join Tbl_StuMarksCard m on m.stu_id=r.StuId 
		inner join Tbl_Subject s on m.Subject_Id=s.Sub_Id inner join Tbl_Course c on 
		c.Course_Id=s.Crs_Id
		where r.RegNo=@regno and m.Result='FAIL' order by Semester 
end
else if @result='PASS'
begin
select m.stu_id,r.RegNo,r.StuName,m.Course_Id as CourseId,m.Subject_Id,s.Sub_Name,s.Sub_th_Max,s.Sub_th_Min,
		m.Th_Sec,s.Sub_IA_Max,s.Sub_IA_Min,m.IA_Sec,s.Sub_Sum_th_IA,m.Total_Sec,m.Result,m.Year,
		m.Percentage,m.SGPA,m.G_Total,m.Final_Result,m.Semester,c.Course_Name
		from Tbl_StuRegister r left join Tbl_StuMarksCard m on m.stu_id=r.StuId 
		inner join Tbl_Subject s on m.Subject_Id=s.Sub_Id inner join Tbl_Course c on 
		c.Course_Id=s.Crs_Id
		where r.RegNo=@regno and m.Final_Result='PASS' order by Semester
end

GO
/****** Object:  StoredProcedure [dbo].[Prc_SubAllView]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Prc_SubAllView]
(
	@Subject_Id int
)
as
begin
select * from Tbl_Subject where Sub_Id=@Subject_Id
end
GO
/****** Object:  StoredProcedure [dbo].[Prc_SubUpdate]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Prc_SubUpdate]
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
GO
/****** Object:  StoredProcedure [dbo].[Prc_SubView]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Prc_SubView]
(
	@Parameter varchar(50),
	@flag int
)
as

/** Sort subject according to there course ******/
if(@flag=1)
begin
/*select Sub_Id,Sub_Code,Sub_Name,Sub_Descript,Sub_Category,Crs_Id,Course_Code,Course_Name,Sub_th_Max,Sub_th_Min,Sub_IA_Max,Sub_IA_Min from Tbl_Subject s,Tbl_Course c where Crs_Id=@Parameter and s.Crs_Id=c.Course_Id*/
select Sub_Id,Sub_Code,Sub_Name,Sub_Descript,Sub_Category,Crs_Id,Course_Code,Course_Name,Sub_th_Max,Sub_th_Min,Sub_IA_Max,Sub_IA_Min
from Tbl_Subject s join Tbl_Course c on s.Crs_Id=c.Course_Id and Crs_Id=@Parameter
end
/** Search subject according to there Subject Code ******/
else if @flag=2
begin
/*select Sub_Id,Sub_Code,Sub_Name,Sub_Descript,Sub_Category,Crs_Id,Course_Code,Course_Name,Sub_th_Max,Sub_th_Min,Sub_IA_Max,Sub_IA_Min from Tbl_Subject s,Tbl_Course c where Sub_Code=@Parameter and s.Crs_Id=c.Course_Id*/
select Sub_Id,Sub_Code,Sub_Name,Sub_Descript,Sub_Category,Crs_Id,Course_Code,Course_Name,Sub_th_Max,Sub_th_Min,Sub_IA_Max,Sub_IA_Min from
Tbl_Subject s join Tbl_Course c on s.Crs_Id=c.Course_Id and (Sub_Code like @Parameter+'%' or Sub_Name like '%'+@Parameter+'%')

end







GO
/****** Object:  StoredProcedure [dbo].[Prc_View_qck_name]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Prc_View_qck_name]
as
begin
select CONCAT(StuName,' - ',RegNo)as StuInfo,RegNo from Tbl_StuRegister
end


GO
/****** Object:  StoredProcedure [dbo].[Prc_View_qck_stuinfo]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Prc_View_qck_stuinfo]
(
	@para varchar(50)
)
as
begin
select distinct RegNo,StuName,Gender,DOB,
AadhaarNo,Course_Name,FName,FPhNo,
m.Semester,m.Max_Marks,m.G_Total,m.SGPA,
m.Final_Result
from Tbl_StuRegister s 
left join Tbl_Course c on s.CourseId=c.Course_Id
left join Tbl_StuMarksCard m on m.stu_id=s.StuId
where
RegNo=@para 
end


GO
/****** Object:  StoredProcedure [dbo].[Prc_ViewSemMarks]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Prc_ViewSemMarks]
(
	@course_id int,
	@semester varchar(50),
	@regno varchar(50),
	@ERROR varchar(100) OUT
)
as
if exists(select distinct m.stu_id,s.RegNo from Tbl_StuMarksCard m, Tbl_StuRegister s  where m.stu_id =s.StuId and m.Semester=@semester and s.RegNo=@regno)
begin
set @ERROR='Marks already exists. To update Goto -> Report Card -> View Marks -> Update '
end
else
begin
select distinct Sub_Id as Subject_Id,Sub_Name,Cours_Id as Course_Id,Semester,
Sub_th_Max,Sub_th_Min,Sub_IA_Max,Sub_IA_Min,Sub_Id as Subject_Id,
StuId as stu_id from Tbl_Subject s,Tbl_Mapping m,Tbl_Course c,
Tbl_StuRegister where 
m.Cours_Id=c.Course_Id and m.Cours_Id=@course_id and s.Sub_Id=m.Subject_Id and m.Semester=@semester and s.Sub_Category not like 'Susidiary (Not Added To Total Marks)' and
(s.Sub_Category not like 'I Language' or (Tbl_StuRegister.RegNo=@regno and Tbl_StuRegister.ILangId=s.Sub_Id)) and Tbl_StuRegister.RegNo=@regno
set @ERROR='New Entry, Please fill all feilds :)'
end





GO
/****** Object:  StoredProcedure [dbo].[Prc_ViewSemMarks_Update]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Prc_ViewSemMarks_Update]
(
	@course_id int,
	@semester varchar(50),
	@regno varchar(50),
	@ERROR varchar(100) OUT
)
as
begin
select m.Card_Id,m.stu_id,r.RegNo,r.StuName,m.Course_Id as Course_Id,m.Subject_Id,s.Sub_Name,s.Sub_th_Max,s.Sub_th_Min,
		m.Th_Sec,s.Sub_IA_Max,s.Sub_IA_Min,m.IA_Sec,s.Sub_Sum_th_IA,m.Total_Sec,m.Result,m.Year,
		m.Percentage,m.SGPA,m.G_Total,m.Final_Result,m.Semester,c.Course_Name
		from Tbl_StuRegister r left join Tbl_StuMarksCard m on m.stu_id=r.StuId 
		inner join Tbl_Subject s on m.Subject_Id=s.Sub_Id inner join Tbl_Course c on 
		c.Course_Id=s.Crs_Id
		where 
		r.RegNo=@regno and Semester=@semester and 
		s.Sub_Category not like('Susidiary (Not Added To Total Marks)')
		order by s.Sub_th_Max 
set @ERROR='Update marks or Year :)'
end




GO
/****** Object:  StoredProcedure [dbo].[Prc_ViewStu_Marks]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Prc_ViewStu_Marks]
(
	@regno varchar(max),
	@semester varchar(50)
)
as
begin
select
m.Card_Id,m.stu_id,m.Course_Id,m.Semester,m.Subject_Id,m.Th_Sec,
m.IA_Sec,m.Total_Sec,m.Result,m.Year,m.Max_Marks,m.G_Total,
m.SGPA,m.Final_Result,m.Percentage,s.Sub_Name,c.Course_Name,
s.Sub_IA_Max,s.Sub_IA_Min,s.Sub_th_Max,s.Sub_th_Min,s.Sub_Sum_th_IA,r.RegNo,r.StuName
from 
Tbl_StuMarksCard m inner join Tbl_StuRegister r
on 
m.stu_id=r.StuId inner join Tbl_Subject s on s.Sub_Id=m.Subject_Id right join Tbl_Course c 
on m.Course_Id=c.Course_Id where r.RegNo=@regno and m.Semester=@semester
end
GO
/****** Object:  StoredProcedure [dbo].[Prc_ViewStu_Marks_AllSem]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Prc_ViewStu_Marks_AllSem]
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
GO
/****** Object:  StoredProcedure [dbo].[Prc_ViewStuCrsYear]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Prc_ViewStuCrsYear]
(
	@CourseId varchar(50),
	@Year varchar(50)
)
as
begin
/*				select distinct Tbl_StuRegister.StuId,Tbl_StuRegister.RegNo,Tbl_StuRegister.StuName,
				Tbl_StuRegister.DOB,Tbl_StuRegister.Gender,Tbl_StuRegister.AadhaarNo,
					Tbl_StuRegister.StuPhNo,Tbl_StuRegister.StuEmail,
					Tbl_StuRegister.FName,Tbl_StuRegister.FPhNo,Tbl_StuRegister.FEmail,
					Tbl_StuRegister.CourseId,Tbl_StuRegister.ILangId,
					Tbl_Course.Course_Name,Tbl_Subject.Sub_Name 
					from Tbl_StuRegister,Tbl_Course,Tbl_Subject 
					where Tbl_Subject.Sub_Id=Tbl_StuRegister.ILangId
						and Tbl_StuRegister.CourseId=Tbl_Course.Course_Id and Tbl_StuRegister.CourseId=@CourseId
						and Tbl_StuRegister.RegNo like @Year + '%'	*/

						select stu.StuId,stu.RegNo,StuName,stu.DOB,stu.Gender,stu.AadhaarNo,
		stu.StuPhNo,stu.StuEmail,stu.FName,stu.FPhNo,stu.FEmail,stu.CourseId,
		stu.ILangId,crs.Course_Name,sub.Sub_Name from Tbl_StuRegister stu 
		left join Tbl_Course crs on stu.CourseId=crs.Course_Id 
		inner join Tbl_Subject sub on sub.Sub_Id=stu.ILangId 
		where stu.RegNo like @Year+'%' and stu.CourseId=@CourseId
end

GO
/****** Object:  StoredProcedure [dbo].[Prc_ViewStuDob]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Prc_ViewStuDob]
(
	@dob date
)
as
begin
select distinct Tbl_StuRegister.StuId,Tbl_StuRegister.RegNo,Tbl_StuRegister.StuName,Tbl_StuRegister.DOB,Tbl_StuRegister.Gender,Tbl_StuRegister.AadhaarNo,
Tbl_StuRegister.StuPhNo,Tbl_StuRegister.StuEmail,Tbl_StuRegister.FName,Tbl_StuRegister.FPhNo,Tbl_StuRegister.FEmail,Tbl_StuRegister.CourseId,Tbl_StuRegister.ILangId,
Tbl_Course.Course_Name,Tbl_Subject.Sub_Name from Tbl_StuRegister,Tbl_Course,Tbl_Subject where Tbl_StuRegister.DOB=@dob and Tbl_Course.Course_Id=Tbl_StuRegister.CourseId 
and Tbl_Subject.Sub_Id=Tbl_StuRegister.ILangId
end
GO
/****** Object:  StoredProcedure [dbo].[Prc_ViewStuRegno]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Prc_ViewStuRegno]
(
	@RegNo varchar(50)
)
as
begin
/*select distinct Tbl_StuRegister.StuId,Tbl_StuRegister.RegNo,Tbl_StuRegister.StuName,Tbl_StuRegister.DOB,Tbl_StuRegister.Gender,Tbl_StuRegister.AadhaarNo,
Tbl_StuRegister.StuPhNo,Tbl_StuRegister.StuEmail,Tbl_StuRegister.FName,Tbl_StuRegister.FPhNo,Tbl_StuRegister.FEmail,Tbl_StuRegister.CourseId,Tbl_StuRegister.ILangId,
Tbl_Course.Course_Name,Tbl_Subject.Sub_Name from Tbl_StuRegister,Tbl_Course,Tbl_Subject where Tbl_StuRegister.RegNo=@RegNo and Tbl_Course.Course_Id=Tbl_StuRegister.CourseId 
and Tbl_Subject.Sub_Id=Tbl_StuRegister.ILangId*/
select r.StuId,r.RegNo,r.StuName,r.DOB,r.Gender,r.AadhaarNo,
r.StuPhNo,r.StuEmail,r.FName,r.FPhNo,r.FEmail,r.CourseId,r.ILangId,
c.Course_Name,s.Sub_Name from Tbl_StuRegister r left join Tbl_Course c on c.Course_Id=r.CourseId
inner join Tbl_Subject s on s.Sub_Id=r.ILangId where (r.RegNo=@RegNo or r.StuName=@RegNo)
end






GO
/****** Object:  StoredProcedure [dbo].[Prc_ViewSubsidairy]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Prc_ViewSubsidairy]
(
	@course_id int,
	@semester varchar(50),
	@regno varchar(50),
	@ERROR varchar(100) OUT
)
as
if exists(select distinct m.stu_id,s.RegNo from Tbl_StuMarksCard m, Tbl_StuRegister s  where m.stu_id =s.StuId and m.Semester=@semester and s.RegNo=@regno)
begin
set @ERROR='Marks already exists. To update Goto -> Report Card -> View Marks -> Update '
end
else
begin
select distinct Sub_Id as Subject_Id,Sub_Name,Cours_Id as Course_Id,Semester,Sub_th_Max,Sub_th_Min,Sub_IA_Max,Sub_IA_Min,StuId as stu_id from Tbl_Subject s,Tbl_Mapping m,Tbl_Course c,Tbl_StuRegister where 
m.Cours_Id=@course_id and m.Semester=@semester and m.Subject_Id=s.Sub_Id and
(s.Sub_Category like 'Susidiary (Not Added To Total Marks)' and (Tbl_StuRegister.RegNo=@regno) )
set @ERROR='New Entry, Please fill all feilds :)'
end

GO
/****** Object:  StoredProcedure [dbo].[Prc_ViewSubsidairy_Update]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Prc_ViewSubsidairy_Update]
(
	@course_id int,
	@semester varchar(50),
	@regno varchar(50),
	@ERROR varchar(100) OUT
)
as
begin
select m.Card_Id,m.stu_id,r.RegNo,r.StuName,m.Course_Id as Course_Id,m.Subject_Id,s.Sub_Name,s.Sub_th_Max,s.Sub_th_Min,
		m.Th_Sec,s.Sub_IA_Max,s.Sub_IA_Min,m.IA_Sec,s.Sub_Sum_th_IA,m.Total_Sec,m.Result,m.Year,
		m.Percentage,m.SGPA,m.G_Total,m.Final_Result,m.Semester,c.Course_Name
		from Tbl_StuRegister r left join Tbl_StuMarksCard m on m.stu_id=r.StuId 
		inner join Tbl_Subject s on m.Subject_Id=s.Sub_Id inner join Tbl_Course c on 
		c.Course_Id=s.Crs_Id
		where 
		r.RegNo=@regno and Semester=@semester and 
		s.Sub_Category like('Susidiary (Not Added To Total Marks)')
		order by s.Sub_th_Max 
set @ERROR='Update marks or Year :)'
end

GO
/****** Object:  StoredProcedure [dbo].[PrcChkCrsSub]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[PrcChkCrsSub]
(
	@Crs_Id int
)
as
begin 
/*select s.Sub_Name ,s.Sub_Id,s.Crs_Id from Tbl_Subject s,Tbl_Course c where Sub_IsActive=1 and s.Crs_Id=c.Course_Id and s.Crs_Id=1*/
/*select distinct s.Sub_Name ,s.Sub_Id,s.Crs_Id from Tbl_Subject s join Tbl_Course c on s.Crs_Id=@Crs_Id*/
/*select Crs_Id,Sub_Id,Sub_Name from Tbl_Subject where Crs_Id=@Crs_Id*/
select Crs_Id,Sub_Id,Sub_Name from Tbl_Subject s where s.Crs_Id=@Crs_Id and s.Sub_Id 
not in(select Sub_Id from Tbl_Subject s join Tbl_Mapping m on m.Subject_Id=s.Sub_Id and s.Sub_Category not like '%'+'Language'+'%' group by s.Sub_Id)

end
GO
/****** Object:  StoredProcedure [dbo].[PrcComboLang]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[PrcComboLang]
(
	@CourseId int
)
as
begin
select Sub_Id as keys,Sub_Name as value from Tbl_Subject where Sub_Category like 'I Language' and Crs_Id=@CourseId
end
GO
/****** Object:  StoredProcedure [dbo].[PrcComboSub]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PrcComboSub]
as
begin 
select Course_Name as value,Course_Id as keys from dbo.Tbl_Course where Course_IsActive=1;
end
GO
/****** Object:  StoredProcedure [dbo].[PrcCourseInsert]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[PrcCourseInsert]
(
	@Course_Code varchar(50),
	@Course_Name varchar(50),
	@Course_Descript text,
	@Course_Date date,
	@ERROR varchar(100) out
)
as
if exists(select Course_Code,Course_Name from Tbl_Course where Course_Code=@Course_Code or Course_Name=@Course_Name)
begin 
set @ERROR='Course Code or Course Name Already Exists.'
end
else
begin
insert into dbo.Tbl_Course values(@Course_Code,@Course_Name,@Course_Descript,@Course_Date,1);
set @ERROR=@Course_Name+' Saved Successfully.'
end
GO
/****** Object:  StoredProcedure [dbo].[PrcCrsMgmtView]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[PrcCrsMgmtView]
as
begin
select Course_Name,Sub_Name,Semester from Tbl_Course c,Tbl_Subject s,Tbl_Mapping m where c.Course_Id=m.Cours_Id and s.Sub_Id=m.Subject_Id order by Course_Name
end



GO
/****** Object:  StoredProcedure [dbo].[PrcMapInsert]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[PrcMapInsert]
(
	@Cours_Id int,
	@Subject_Id int,
	@Semester varchar(50),
	@MapDate date,
	@ERROR varchar(100) OUT
)
as
if exists(select Cours_Id from Tbl_Mapping where Cours_Id=@Cours_Id and Subject_Id=@Subject_Id and Semester=@Semester)
begin
set @ERROR='Subject is already mapped with Course and Sem.'
end
else
begin
insert into dbo.Tbl_Mapping values (@Cours_Id,@Subject_Id,@Semester,@MapDate)
set @ERROR='Subject Mapped Successfully.'
end




GO
/****** Object:  StoredProcedure [dbo].[PrcSubInsert1]    Script Date: 05-03-2021 22:00:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PrcSubInsert1]
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

GO
USE [master]
GO
ALTER DATABASE [dbclg] SET  READ_WRITE 
GO
