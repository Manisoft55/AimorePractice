CREATE PROC usp_InsertEmployee
(
@EmpFirstName nvarchar(50),
@EmpLastName nvarchar(50),
@EmpAge int,
@EmpSalary int
)

AS 

BEGIN

INSERT INTO EmployeeDetails(EmpFirstName, EmpLastName, EmpAge, EmpSalary)
values (@EmpFirstName, @EmpLastName, @EmpAge, @EmpSalary)

END