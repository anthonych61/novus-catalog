/* Write your T-SQL query statement below */
SELECT email FROM Person
Group By email
Having Count(id) > 1;