create procedure Prc_Marks_Save_Grid
(
	@Slno int,
	@regno varchar(50),
	@stu_name text,
	@crs_id int,
	@crs_name varchar(50),
	@semester varchar(50),
	@sub_id int,
	@sub_name varchar(50),
	@th_max int,
	@th_min int,
	@th_sec int,
	@IA_max int,
	@IA_min int,
	@IA_sec int,
	@total_max int,
	@total_sec int,
	@result varchar(50),
	@remarks int
)
as
insert into Tbl_StuMarksCard values 
(
	@Slno ,
	@regno ,
	@stu_name,
	@crs_id ,
	@crs_name ,
	@semester ,
	@sub_id ,
	@sub_name ,
	@th_max ,
	@th_min ,
	@th_sec ,
	@IA_max ,
	@IA_min ,
	@IA_sec ,
	@total_max ,
	@total_sec ,
	@result ,
	@remarks 
)