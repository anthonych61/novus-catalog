/* Write your T-SQL query statement below */
SELECT user_id, name, mail
FROM Users
WHERE LEFT(mail,1) LIKE '[a-zA-Z]%' AND LEFT(mail,LEN(mail) - 13) NOT LIKE '%[^a-zA-Z0-9_.-]%' AND RIGHT(MAIL, 13) = '@leetcode.com'