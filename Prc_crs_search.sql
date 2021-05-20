USE [dbclg]
GO
/****** Object:  StoredProcedure [dbo].[Prc_crs_search]    Script Date: 01-07-2020 22:18:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Prc_crs_search]
(
	@Course_Code varchar(50)
)
as
begin
select Course_Id,Course_Code,Course_Name,Course_Descript from Tbl_Course where Course_Code=@Course_Code
end
