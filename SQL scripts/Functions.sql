select * from CompanyDetails

Update CompanyDetails set CompanyMobile = 123.4534534 where CompanyId = 2

select abs(CompanyMobile) from CompanyDetails

select round(123.4534534, 2)

select upper(CompanyEmail) from CompanyDetails


select lower(CompanyAddressLine1) from CompanyDetails

select rtrim(ltrim('   Medavakkam  '))

select min(CompanyMobile) from CompanyDetails


select count(*) from CompanyDetails

sp_spaceused 'CompanyDetails'