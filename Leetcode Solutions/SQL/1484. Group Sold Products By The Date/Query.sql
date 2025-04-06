/* Write your T-SQL query statement below */
SELECT sell_date, COUNT(product) As num_sold, STRING_AGG(product,',') WITHIN GROUP (ORDER BY product) as products
FROM (SELECT DISTINCT * FROM Activities) d
GROUP BY sell_date
ORDER BY sell_date