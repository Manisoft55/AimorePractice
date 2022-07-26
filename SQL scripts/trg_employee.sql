USE [InstituteCmd]
GO
/****** Object:  Trigger [dbo].[trg_employee]    Script Date: 30-09-2022 11:21:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trg_employee]
ON [dbo].[employees]
AFTER UPDATE, INSERT, DELETE
AS
BEGIN
    SET NOCOUNT ON;
    

	DECLARE @insertid int
	DECLARE @deletedid int
    SELECT @insertid = employee_id FROM inserted
	SELECT @deletedid = employee_id FROM deleted

	IF @insertid IS NOT NULL AND @deletedid IS NULL
		BEGIN
				
				INSERT INTO dbo.employeesaudit(
					employee_id,
				first_name,
				last_name,
				email,
				phone_number,
				hire_date,
				job_id,
				salary,
				manager_id,
				department_id,
				operation
				)
				SELECT
					employee_id,
				first_name,
				last_name,
				email,
				phone_number,
				hire_date,
				job_id,
				salary,
				manager_id,
				department_id,
					'INS'
				FROM
					inserted i			 

		END
	ELSE IF @insertid IS NULL AND @deletedid IS NOT NULL
		BEGIN
			INSERT INTO dbo.employeesaudit(
        employee_id,
	first_name,
	last_name,
	email,
	phone_number,
	hire_date,
	job_id,
	salary,
	manager_id,
	department_id,
	operation
    )
    SELECT
        employee_id,
	first_name,
	last_name,
	email,
	phone_number,
	hire_date,
	job_id,
	salary,
	manager_id,
	department_id,
        'DEL'
    FROM
        inserted i   
	END
ELSE
BEGIN
INSERT INTO dbo.employeesaudit(
        employee_id,
	first_name,
	last_name,
	email,
	phone_number,
	hire_date,
	job_id,
	salary,
	manager_id,
	department_id,
	operation
    )
    SELECT
        employee_id,
	first_name,
	last_name,
	email,
	phone_number,
	hire_date,
	job_id,
	salary,
	manager_id,
	department_id,
        'UPD'
    FROM
        inserted i   
END
END


--InsertedID IS NOT NULL AND DeletedID IS NOT NULL THEN 'Update'
--InsertedID IS NOT NULL AND DeletedID IS NULL THEN 'Insert'
--InsertedID IS NULL AND DeletedID IS NOT NULL THEN 'Delete'