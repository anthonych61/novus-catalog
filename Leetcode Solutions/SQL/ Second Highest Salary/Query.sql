/* Write your T-SQL query statement below */

-- SELECT MAX(salary) As SecondHighestSalary FROM
-- (
--     SELECT salary, dense_rank() OVER (ORDER BY salary desc) As rownumber
--     FROM Employee
-- ) As foo
-- WHERE rownumber = 2

WITH highestSalary As
(
    SELECT salary, 
    dense_rank() OVER (ORDER BY salary desc) As rownumber    
    FROM Employee
)

SELECT distinct max(salary) As SecondHighestSalary
FROM highestSalary
Where rownumber = 2