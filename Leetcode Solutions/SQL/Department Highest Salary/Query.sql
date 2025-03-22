/*

Intuition
To find the employee with the highest salary in each department using T-SQL, you need to:

Determine the maximum salary for each department.
Filter employees to include only those with the maximum salary within their respective departments.
Join this filtered data with the department names to get the desired result.

Approach
Subquery for Maximum Salary: Create a subquery that groups the employees by departmentId and computes the maximum salary (MaxSalary) for each department.
Join Results: Perform a join operation between the Employee table and the Department table, and then join this with the results of the subquery. This will give you the employees who have the maximum salary in their respective departments.
Select Relevant Columns: Choose the columns that are needed for the final output: department name, employee name, and salary.

*/


/* Write your T-SQL query statement below */
SELECT Department.name As Department, Employee.name As Employee, Employee.salary As Salary
FROM Department
JOIN Employee ON Department.id = Employee.departmentId
JOIN (
SELECT departmentId, MAX(salary) as MaxSalary
FROM Employee
GROUP BY departmentId
)t1
ON t1.departmentId = Employee.departmentId 
AND Employee.salary = t1.MaxSalary