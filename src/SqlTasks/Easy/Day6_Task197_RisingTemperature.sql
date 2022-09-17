-- 197. Rising Temperature

-- SQL Schema:

--Create table Weather (id int, recordDate date, temperature int)
--Truncate table Weather
--insert into Weather (id, recordDate, temperature) values ('1', '2015-01-01', '10')
--insert into Weather (id, recordDate, temperature) values ('2', '2015-01-02', '25')
--insert into Weather (id, recordDate, temperature) values ('3', '2015-01-03', '20')
--insert into Weather (id, recordDate, temperature) values ('4', '2015-01-04', '30')

--Table: Weather
--	+---------------+---------+
--	| Column Name   | Type    |
--	+---------------+---------+
--	| id            | int     |
--	| recordDate    | date    |
--	| temperature   | int     |
--	+---------------+---------+
--id is the primary key for this table.
--This table contains information about the temperature on a certain day.
 

--Write an SQL query to find all dates' Id with higher 
--	temperatures compared to its previous dates (yesterday).

--Return the result table in any order.

--The query result format is in the following example.

 

--Example 1:

--Input: 
--Weather table:
--	+----+------------+-------------+
--	| id | recordDate | temperature |
--	+----+------------+-------------+
--	| 1  | 2015-01-01 | 10          |
--	| 2  | 2015-01-02 | 25          |
--	| 3  | 2015-01-03 | 20          |
--	| 4  | 2015-01-04 | 30          |
--	+----+------------+-------------+
--Output: 
--	+----+
--	| id |
--	+----+
--	| 2  |
--	| 4  |
--	+----+
--Explanation: 
--In 2015-01-02, the temperature was higher than the previous day (10 -> 25).
--In 2015-01-04, the temperature was higher than the previous day (20 -> 30).

-- Runtime: 1128 ms, faster than 26.37% of MS SQL Server online submissions for Rising Temperature.
-- Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Rising Temperature.

select 
	b.id 
from 
	Weather a, 
	Weather b
where 
	b.Recorddate = dateadd(day,1, a.recorddate)
	and a.temperature < b.temperature

-----------------------
-- Runtime: 972 ms, faster than 42.67% of MS SQL Server online submissions for Rising Temperature.
-- Memory Usage: 0B, less than 100.00% of MS SQL Server online submissions for Rising Temperature.
select distinct 
	w1.id 
from 
	Weather w1
	inner join Weather w2 
		on DATEDIFF(day, w2.recordDate, w1.recordDate) = 1 --DATEDIFF Разница дней (day) в указаных датах равна 1.
		and w1.temperature > w2.temperature 