CREATE TRIGGER dbo.trg_employee
ON dbo.employees
AFTER INSERT, DELETE
AS
BEGIN
    SET NOCOUNT ON;
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
    UNION ALL
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
        deleted d;
END

CREATE TABLE employees (
	employee_id INT IDENTITY(1,1) PRIMARY KEY,
	first_name VARCHAR (20) DEFAULT NULL,
	last_name VARCHAR (25) NOT NULL,
	email VARCHAR (100) NOT NULL,
	phone_number VARCHAR (20) DEFAULT NULL,
	hire_date DATE NOT NULL,
	job_id INT NOT NULL,
	salary DECIMAL (8, 2) NOT NULL,
	manager_id INT DEFAULT NULL,
	department_id INT DEFAULT NULL
);

CREATE TABLE employeesaudit (
	audit_id INT IDENTITY(1,1) PRIMARY KEY,
	employee_id INT NOT NULL,
	first_name VARCHAR (20) DEFAULT NULL,
	last_name VARCHAR (25) NOT NULL,
	email VARCHAR (100) NOT NULL,
	phone_number VARCHAR (20) DEFAULT NULL,
	hire_date DATE NOT NULL,
	job_id INT NOT NULL,
	salary DECIMAL (8, 2) NOT NULL,
	manager_id INT DEFAULT NULL,
	department_id INT DEFAULT NULL,
	operation VARCHAR(20)
);

select * from employeesaudit

SET IDENTITY_INSERT employees ON;
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,job_id,salary,manager_id,department_id)
select employee_id,first_name,last_name,email,phone_number,hire_date,job_id,salary,manager_id,department_id from employeesaudit where employee_id = 204

select * from employees
select max(employee_id) from employees

delete from employees where employee_id = 204

SET IDENTITY_INSERT employees ON;
INSERT INTO employees(employee_id,first_name,last_name,email,phone_number,hire_date,job_id,salary,manager_id,department_id) VALUES (208,'Steven','Trigger','steven.king@sqltutorial.org','515.123.4567','1987-06-17',4,24000.00,NULL,9);



--employee -> inserted virtual table -> trigger (making an entry in audit)