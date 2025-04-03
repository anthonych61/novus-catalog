/*Given that there's only one table mentioned in the question and that both the employee and the manager are managed in the same table, then the question calls for a SELF JOIN. 
A SELF JOIN is a type of join where a table is joined with itself. 
To join a table with itself, an alias to the table needs to be used to differentiate it when the table is being used to identify employees */

/* Write your T-SQL query statement below */
SELECT A.name As Employee From Employee A, Employee B
WHERE A.managerId = B.id AND A.salary > B.salary