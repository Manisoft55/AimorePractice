CREATE PROC usp_SELECTEmployee

AS 
BEGIN

select dbo.fnGetEmpFullNameTwo(EmpFirstName, '', EmpLastName) from EmployeeDetails

END