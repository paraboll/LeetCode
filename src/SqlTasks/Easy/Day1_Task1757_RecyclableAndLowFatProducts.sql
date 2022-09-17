﻿-- 1757. Recyclable and Low Fat Products

-- SQL Schema:
--Create table Products (product_id int, low_fats ENUM('Y', 'N'), recyclable ENUM('Y','N'));
--Truncate table Products;
--insert into Products (product_id, low_fats, recyclable) values ('0', 'Y', 'N');
--insert into Products (product_id, low_fats, recyclable) values ('1', 'Y', 'Y');
--insert into Products (product_id, low_fats, recyclable) values ('2', 'N', 'Y');
--insert into Products (product_id, low_fats, recyclable) values ('3', 'Y', 'Y');
--insert into Products (product_id, low_fats, recyclable) values ('4', 'N', 'N');


-- Table: Products
-- 	+-------------+---------+
-- 	| Column Name | Type    |
-- 	+-------------+---------+
-- 	| product_id  | int     |
-- 	| low_fats    | enum    |
-- 	| recyclable  | enum    |
-- 	+-------------+---------+
-- product_id is the primary key for this table.
-- low_fats is an ENUM of type ('Y', 'N') where 'Y' means this product is low fat and 'N' means it is not.
-- recyclable is an ENUM of types ('Y', 'N') where 'Y' means this product is recyclable and 'N' means it is not.
   
-- Write an SQL query to find the ids of products that are both low fat and recyclable.
-- Return the result table in any order.
-- The query result format is in the following example.
   
-- Example 1:
-- Input: 
-- Products table:
-- 	+-------------+----------+------------+
-- 	| product_id  | low_fats | recyclable |
-- 	+-------------+----------+------------+
-- 	| 0           | Y        | N          |
-- 	| 1           | Y        | Y          |
-- 	| 2           | N        | Y          |
-- 	| 3           | Y        | Y          |
-- 	| 4           | N        | N          |
-- 	+-------------+----------+------------+
-- Output: 
-- 	+-------------+
-- 	| product_id  |
-- 	+-------------+
-- 	| 1           |
-- 	| 3           |
-- 	+-------------+
-- Explanation: Only products 1 and 3 are both low fat and recyclable.


-- Runtime: 885 ms, faster than 47.63% of MS SQL Server online submissions for Recyclable and Low Fat Products.
-- Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Recyclable and Low Fat Products.

SELECT
	product_id
FROM
	Products
Where
	low_fats = recyclable
	AND low_fats = 'Y';