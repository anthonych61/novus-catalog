/* Write your T-SQL query statement below */
SELECT u.name As NAME, SUM(t.amount) As BALANCE
FROM Users u JOIN Transactions t ON u.account = t.account
GROUP BY u.name
HAVING SUM(t.amount) > 10000