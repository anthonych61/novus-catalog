/* Write your T-SQL query statement below */
SELECT user_id, COUNT(user_id) AS followers_count
FROM Followers
Group by user_id
Order by user_id ASC;