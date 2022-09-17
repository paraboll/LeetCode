﻿-- 183. Customers Who Never Order

-- SQL Schema:
--Create table Customers (id int, name varchar(255))
--Create table Orders (id int, customerId int)
--Truncate table Customers
--insert into Customers (id, name) values ('1', 'Joe')
--insert into Customers (id, name) values ('2', 'Henry')
--insert into Customers (id, name) values ('3', 'Sam')
--insert into Customers (id, name) values ('4', 'Max')
--Truncate table Orders
--insert into Orders (id, customerId) values ('1', '3')
--insert into Orders (id, customerId) values ('2', '1')

--Table: Customers
--	+-------------+---------+
--	| Column Name | Type    |
--	+-------------+---------+
--	| id          | int     |
--	| name        | varchar |
--	+-------------+---------+

--id is the primary key column for this table.
--Each row of this table indicates the ID and name of a customer.
 
--Table: Orders
--	+-------------+------+
--	| Column Name | Type |
--	+-------------+------+
--	| id          | int  |
--	| customerId  | int  |
--	+-------------+------+

--id is the primary key column for this table.
--customerId is a foreign key of the ID from the Customers table.
--Each row of this table indicates the ID of an order 
--	and the ID of the customer who ordered it.
 
--Write an SQL query to report all customers who never order anything.
--Return the result table in any order.
--The query result format is in the following example.

 
--Example 1:
--Input: 
--Customers table:
--	+----+-------+
--	| id | name  |
--	+----+-------+
--	| 1  | Joe   |
--	| 2  | Henry |
--	| 3  | Sam   |
--	| 4  | Max   |
--	+----+-------+
--Orders table:
--	+----+------------+
--	| id | customerId |
--	+----+------------+
--	| 1  | 3          |
--	| 2  | 1          |
--	+----+------------+
--Output: 
--	+-----------+
--	| Customers |
--	+-----------+
--	| Henry     |
--	| Max       |
--	+-----------+

-- Runtime: 625 ms, faster than 72.58% of MS SQL Server online submissions for Customers Who Never Order.
-- Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Customers Who Never Order.
Select
	Customers.name As Customers
From
	Customers 
	Left Join Orders On Customers.Id = Orders.customerId
Where 
	Orders.customerId is null;

--Runtime: 747 ms, faster than 43.23% of MS SQL Server online submissions for Customers Who Never Order.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Customers Who Never Order.
Select
	Customers.name As Customers
From
	Customers 
	Left OUTER Join Orders On Customers.Id = Orders.customerId
Where 
	Orders.customerId is null;