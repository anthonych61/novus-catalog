/* Write your T-SQL query statement below */
SELECT a.sell_date, COUNT(a.product) as num_sold, STRING_AGG(a.product, ',') WITHIN GROUP (ORDER BY a.product) as products
FROM (SELECT DISTINCT sell_date, product FROM Activities) a
Group By sell_date
Order By sell_date