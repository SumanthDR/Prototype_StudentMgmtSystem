USE [dbclg]
GO
/****** Object:  StoredProcedure [dbo].[Prc_ComboSubView]    Script Date: 01-07-2020 19:21:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Prc_ComboSubView]  
( 
	@Course_id int
)
as
begin
select Course_Name as value,Course_Id as keys from dbo.Tbl_Course where Course_IsActive=1 and Course_Id=@Course_id;
end
