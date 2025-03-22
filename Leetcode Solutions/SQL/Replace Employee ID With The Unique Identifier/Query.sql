/* Write your T-SQL query statement below */
Select EmployeeUNI.unique_id, Employees.name
From Employees
LEFT JOIN EmployeeUNI ON Employees.id = EmployeeUNI.id