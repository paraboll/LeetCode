--182. Duplicate Emails

--SQL Schema:
--Create table If Not Exists Person (id int, email varchar(255))
--Truncate table Person
--insert into Person (id, email) values ('1', 'a@b.com')
--insert into Person (id, email) values ('2', 'c@d.com')
--insert into Person (id, email) values ('3', 'a@b.com')

--Table: Person
--	+-------------+---------+
--	| Column Name | Type    |
--	+-------------+---------+
--	| id          | int     |
--	| email       | varchar |
--	+-------------+---------+
--id is the primary key column for this table.
--Each row of this table contains an email. The emails 
--	will not contain uppercase letters.
 

--Write an SQL query to report all the duplicate emails.
--Return the result table in any order.
--The query result format is in the following example.

--Example 1:
--Input: 
--Person table:
--	+----+---------+
--	| id | email   |
--	+----+---------+
--	| 1  | a@b.com |
--	| 2  | c@d.com |
--	| 3  | a@b.com |
--	+----+---------+
--Output: 
--	+---------+
--	| Email   |
--	+---------+
--	| a@b.com |
--	+---------+
--Explanation: a@b.com is repeated two times.

--Runtime: 773 ms, faster than 54.42% of MS SQL Server online submissions for Duplicate Emails.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Duplicate Emails.

Select
    emailTable.email
From(
    Select 
        email,
        Count(email) as emailCount
    from 
        Person
    Group by email
             ) as emailTable
Where emailTable.emailCount > 1

--Runtime: 1028 ms, faster than 25.65% of MS SQL Server online submissions for Duplicate Emails.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Duplicate Emails.

select Email
from Person
group by Email
having count(Email) > 1;