USE [dbclg]
GO
/****** Object:  StoredProcedure [dbo].[Prc_View_qck_name]    Script Date: 25-01-2021 18:16:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Prc_View_qck_name]
as
begin
select CONCAT(StuName,' - ',RegNo)as StuInfo,RegNo from Tbl_StuRegister
end


