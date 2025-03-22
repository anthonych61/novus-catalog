/* Write your T-SQL query statement below */
SELECT Project.project_id, ROUND(AVG(CAST((Employee.experience_years) AS Decimal)),2) As average_years
FROM Project 
JOIN Employee ON Employee.employee_id = Project.employee_id
GROUP BY Project.project_id