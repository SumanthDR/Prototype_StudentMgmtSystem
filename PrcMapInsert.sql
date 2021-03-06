USE [dbclg]
GO
/****** Object:  StoredProcedure [dbo].[PrcMapInsert]    Script Date: 03-07-2020 07:43:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[PrcMapInsert]
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




