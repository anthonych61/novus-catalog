/* Write your T-SQL query statement below */
SELECT activity_date  As day, COUNT(distinct user_id) As active_users
FROM Activity
WHERE activity_date BETWEEN DATEADD(dd, -29,'2019-07-27') AND '2019-07-27' 
Group by activity_date