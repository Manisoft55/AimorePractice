SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CreateEmployee] 
@first_name varchar(20),
@last_name varchar(25),
@email varchar(100),
@phone_number varchar(20),
@hire_date date,
@job_id int,
@salary decimal(8,2),
@manager_id int,
@department_id int,
@empid int OUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into employees(first_name,
	last_name,
	email,
	phone_number,
	hire_date,
	job_id,
	salary,
	manager_id,
	department_id)
	values(
	@first_name,
	@last_name,
	@email,
	@phone_number,
	@hire_date,
	@job_id,
	@salary,
	@manager_id,
	@department_id
	)

	SELECT @empid = SCOPE_IDENTITY()
END
GO
