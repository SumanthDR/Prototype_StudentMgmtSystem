USE [dbclg]
GO
/****** Object:  StoredProcedure [dbo].[Prc_SubAllView]    Script Date: 01-07-2020 10:11:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Prc_SubAllView]
(
	@Subject_Id int
)
as
begin
select * from Tbl_Subject where Sub_Id=@Subject_Id
end

