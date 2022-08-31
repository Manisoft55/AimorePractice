CREATE TABLE EmployeeDetails(
EmpId int not null primary key identity(1,1),
EmpFirstName nvarchar(50) not null,
EmpLastName nvarchar(50) not null,
EmpAge int not null,
EmpSalary int not null
)