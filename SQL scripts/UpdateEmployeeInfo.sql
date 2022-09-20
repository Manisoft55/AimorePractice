
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UpdateEmployeeInfo]
	@employee_id int ,
	@first_name varchar(20),
	@last_name varchar(25),
	@email varchar(100),
	@phone_number varchar(20),
	@hire_date date,
	@job_id int,
	@salary decimal(8,2),
	@manager_id int,
	@department_id int	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    Update employees set first_name = @first_name, last_name = @last_name, email = @email, phone_number= @phone_number, hire_date = @hire_date, job_id = @job_id,
	salary = @salary, manager_id = @manager_id, department_id = @department_id where employee_id = @employee_id
END
GO
