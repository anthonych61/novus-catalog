/* Write your T-SQL query statement below */
SELECT class 
FROM Courses
GROUP BY class
Having COUNT(student) >= 5;
