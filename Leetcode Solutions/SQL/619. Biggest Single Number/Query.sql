/* Write your T-SQL query statement below */
SELECT COALESCE ((SELECT TOP 1 MAX(num) 
FROM MyNumbers
Group By num
Having COUNT (num) = 1
Order By num DESC),null ) as num