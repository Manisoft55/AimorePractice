USE [InstituteCmd]
GO

/****** Object:  StoredProcedure [dbo].[InsertCompany]    Script Date: 29-08-2022 17:44:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[InsertCompany]
@CompanyName nvarchar(50),
@CompanyEmail nvarchar(50),
@CompanyMobile bigint,
@CompanyAddressLine1 nvarchar(50),
@CompanyAddressLine2 nvarchar(50),
@CompanyActiveStatus bit,
@CompanyCreatedDate datetime,
@CompanyUpdatedDate datetime,
@CompanyGST nvarchar(50)

AS

	BEGIN
		insert into CompanyDetails(CompanyName, CompanyMobile, CompanyAddressLine1, CompanyAddressLine2, CompanyEmail, CompanyGST)
		values(@CompanyName, @CompanyMobile, @CompanyAddressLine1 , @CompanyAddressLine2, @CompanyEmail, @CompanyGST)
	END

GO


