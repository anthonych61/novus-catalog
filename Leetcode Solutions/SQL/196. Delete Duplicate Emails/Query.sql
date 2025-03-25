/* Write your T-SQL query statement below */
DELETE FROM Person 
WHERE id NOT IN (SELECT Min(id) FROM Person Group By email )