﻿-- 584. Find Customer Referee

-- SQL Schema:

--Create table Customer (id int, name varchar(25), referee_id int)
--Truncate table Customer
--insert into Customer (id, name, referee_id) values ('1', 'Will', 'None')
--insert into Customer (id, name, referee_id) values ('2', 'Jane', 'None')
--insert into Customer (id, name, referee_id) values ('3', 'Alex', '2')
--insert into Customer (id, name, referee_id) values ('4', 'Bill', 'None')
--insert into Customer (id, name, referee_id) values ('5', 'Zack', '1')
--insert into Customer (id, name, referee_id) values ('6', 'Mark', '2')

--Table: Customer
--	+-------------+---------+
--	| Column Name | Type    |
--	+-------------+---------+
--	| id          | int     |
--	| name        | varchar |
--	| referee_id  | int     |
--	+-------------+---------+

--id is the primary key column for this table.
--Each row of this table indicates the id of a customer, 
--	their name, and the id of the customer who referred them.
 

--Write an SQL query to report the names of the 
--	customer that are not referred by the customer with id = 2.

--Return the result table in any order.
--The query result format is in the following example.

--Example 1:
--Input: 
--Customer table:
--	+----+------+------------+
--	| id | name | referee_id |
--	+----+------+------------+
--	| 1  | Will | null       |
--	| 2  | Jane | null       |
--	| 3  | Alex | 2          |
--	| 4  | Bill | null       |
--	| 5  | Zack | 1          |
--	| 6  | Mark | 2          |
--	+----+------+------------+
--Output: 
--	+------+
--	| name |
--	+------+
--	| Will |
--	| Jane |
--	| Bill |
--	| Zack |
--	+------+

-- Runtime: 932 ms, faster than 71.67% of MS SQL Server online submissions for Find Customer Referee.
-- Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Find Customer Referee.

SELECT
	name
FROM
	Customer
Where referee_id <> 2
	Or referee_id is null;