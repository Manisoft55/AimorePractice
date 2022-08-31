select * from EmployeeDetails

select EmpFirstName + ' ' + EmpLastName from EmployeeDetails

select dbo.fnGetEmpFullName(EmpFirstName, EmpLastName) from EmployeeDetails

exec usp_InsertEmployee 'Ramesh', 'Kumar', 23, 78000

exec usp_SELECTEmployee

SELECT 'Mani' + 5

select * from EmployeeDetails

select * from dbo.fnGetEmployee()