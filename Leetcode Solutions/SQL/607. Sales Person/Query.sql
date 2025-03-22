/* Write your T-SQL query statement below */
--SELECT name FROM SalesPerson WHERE name NOT IN (
--SELECT s.name FROM SalesPerson As s
--JOIN Orders As o ON o.sales_id = s.sales_id
--JOIN Company As c ON c.com_id = o.com_id
--WHERE c.name = 'RED'
--)
SELECT name FROM SalesPerson s WHERE name NOT IN (
SELECT s.name FROM Orders o, Company c 
WHERE o.sales_id = s.sales_id AND c.com_id = o.com_id AND c.name = 'RED')