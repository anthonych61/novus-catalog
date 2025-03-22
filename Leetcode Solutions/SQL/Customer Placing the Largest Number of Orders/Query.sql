/* Write your T-SQL query statement below */
SELECT TOP 1 customer_number 
FROM Orders
Group By customer_number 
Order by COUNT(*) DESC 