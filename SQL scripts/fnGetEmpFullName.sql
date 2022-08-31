Create function fnGetEmpFullNameTwo
(
 @FirstName varchar(50),
 @MiddleName varchar(50),
 @LastName varchar(50)
)
returns varchar(101)
As
Begin 

return (

Select @FirstName + ' '+@MiddleName + ' ' + @LastName
);
end 
