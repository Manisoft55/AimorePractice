-- SQL Script

CREATE TABLE CompanyDetails(
CompanyId int not null primary key identity(1,1),
CompanyName nvarchar(50) null,
CompanyEmail nvarchar(100) null,
CompanyMobile bigint null,
CompanyAddressLine1 nvarchar(500) null,
CompanyAddressLine2 nvarchar(500) null,
CompanyActiveStatus bit default(1), --Default Constraint
CompanyCreatedDate datetime not null default(getdate()),
CompanyUpdatedDate datetime null
)

INSERT INTO CompanyDetails(CompanyName, CompanyEmail, CompanyMobile, CompanyAddressLine1, CompanyAddressLine2, CompanyActiveStatus, CompanyCreatedDate)
VALUES('TCS', 'TCS@gmail.com', 98878766, 'Medavakkam, Chennai - 600119', 'Chennai', 0, getdate()-1);

select * from CompanyDetails;

UPDATE CompanyDetails set CompanyActiveStatus = 1, CompanyCreatedDate = GETDATE() where CompanyId = 2;

Update CompanyDetails set CompanyUpdatedDate = getdate()

delete from CompanyDetails where companyid = 2

delete from CompanyDetails

truncate table CompanyDetails

drop table CompanyDetails