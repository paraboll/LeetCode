﻿-- 586. Customer Placing the Largest Number of Orders

--SQL Schema:
--Create table orders (order_number int, customer_number int)
--Truncate table orders
--insert into orders (order_number, customer_number) values ('1', '1')
--insert into orders (order_number, customer_number) values ('2', '2')
--insert into orders (order_number, customer_number) values ('3', '3')
--insert into orders (order_number, customer_number) values ('4', '3')

--Table: Orders
--	+-----------------+----------+
--	| Column Name     | Type     |
--	+-----------------+----------+
--	| order_number    | int      |
--	| customer_number | int      |
--	+-----------------+----------+
--order_number is the primary key for this table.
--This table contains information about the order ID and the customer ID.
 

--Write an SQL query to find the customer_number for the customer who has placed the largest number of orders.
--The test cases are generated so that exactly one customer will have placed more orders than any other customer.
--The query result format is in the following example.

--Example 1:
--Input: 
--Orders table:
--	+--------------+-----------------+
--	| order_number | customer_number |
--	+--------------+-----------------+
--	| 1            | 1               |
--	| 2            | 2               |
--	| 3            | 3               |
--	| 4            | 3               |
--+--------------+-----------------+
--Output: 
--	+-----------------+
--	| customer_number |
--	+-----------------+
--	| 3               |
--	+-----------------+
--Explanation: 
--The customer with number 3 has two orders, which is greater than either customer 1 or 2 because each of them only has one order. 
--So the result is customer_number 3.
 

--Follow up: What if more than one customer has the largest number of orders, can you find all the customer_number in this case?

--Runtime: 1083 ms, faster than 35.75% of MS SQL Server online submissions for Customer Placing the Largest Number of Orders.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Customer Placing the Largest Number of Orders.

SELECT TOP 1
    customer_number
FROM 
    Orders
GROUP BY customer_number
ORDER BY COUNT(order_number) DESC


--Runtime: 1046 ms, faster than 40.40% of MS SQL Server online submissions for Customer Placing the Largest Number of Orders.
--Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Customer Placing the Largest Number of Orders.

with CTE1 as (select count(*) as 'orders', Customer_number from Orders group by Customer_number)
    
select Customer_number from CTE1 where orders in (select MAX(orders) from CTE1);