/* Write your T-SQL query statement below */
SELECT FORMAT(trans_date,'yyyy-MM') As month,
country,
COUNT(*) As trans_count, 
COUNT(CASE WHEN state = 'approved' THEN state END) As approved_count,
SUM(CASE WHEN state = 'approved' OR state = 'declined' THEN amount END) As trans_total_amount,
SUM(CASE WHEN state = 'approved' THEN amount ELSE 0 END) As approved_total_amount
FROM Transactions
GROUP BY FORMAT(trans_date,'yyyy-MM'), country
ORDER BY FORMAT(trans_date,'yyyy-MM') 