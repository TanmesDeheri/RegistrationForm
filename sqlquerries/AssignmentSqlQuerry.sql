/*Use AdventureWorks2022;
Select * From HumanResources.Department;
SELECT DISTINCT GroupName from HumanResources.Department;

Select * from HumanResources.Employee;
Select NationalIDNumber,LoginID,JobTitle from HumanResources.Employee where JobTitle='Production Technician - WC45';
Select NationalIDNumber,LoginID,JobTitle from HumanResources.Employee where OrganizationLevel is null;
Update HumanResources.Employee
Set Gender='F'
where JobTitle='Chief Executive Officer';
select * from HumanResources.Employee;

select * from HumanResources.Employee;
select * from HumanResources.EmployeeDepartmentHistory;
select * from HumanResources.Department;

CREATE PROCEDURE NameLoginEndDate AS 
select Person.Person.FirstName,Person.Person.LastName, HumanResources.Employee.LoginID,
HumanResources.EmployeeDepartmentHistory.EndDate 
from ((HumanResources.Employee inner join Person.Person
on HumanResources.Employee.BusinessEntityID=Person.BusinessEntityID)
inner join HumanResources.EmployeeDepartmentHistory
on HumanResources.Employee.BusinessEntityID=HumanResources.EmployeeDepartmentHistory.BusinessEntityID)
where HumanResources.EmployeeDepartmentHistory.EndDate is not null

EXEC NameLoginEndDate;

SELECT * FROM Person.Person ORDER BY LastName ASC;
SELECT FirstName AS firstname, LastName AS lastname,BusinessEntityID AS employee_id FROM Person.Person;
SELECT ProductID,ProductNumber,Name AS ProductName FROM Production.Product WHERE SellStartDate IS NOT NULL AND ProductLine='T' ORDER BY Name;*/
