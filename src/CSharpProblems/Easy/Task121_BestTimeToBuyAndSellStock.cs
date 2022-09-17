using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProblems.Easy
{
    //121. Best Time to Buy and Sell Stock

    //You are given an array prices where prices[i] is 
    //    the price of a given stock on the ith day.

    //You want to maximize your profit by choosing a 
    //        single day to buy one stock and choosing a 
    //        different day in the future to sell that stock.

    //Return the maximum profit you can achieve from 
    //        this transaction.If you cannot achieve any profit, return 0.

    //Example 1:
    //Input: prices = [7, 1, 5, 3, 6, 4]
    //Output: 5
    //Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
    //Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
    
    //Example 2:
    //Input: prices = [7,6,4,3,1]
    //    Output: 0
    //Explanation: In this case, no transactions are done and the max profit = 0.

    //Constraints:
    //    1 <= prices.length <= 105
    //    0 <= prices[i] <= 104
    public class Task121_BestTimeToBuyAndSellStock
    {
        // Runtime: 244 ms, faster than 91.29% of C# online submissions for Best Time to Buy and Sell Stock.
        // Memory Usage: 49.6 MB, less than 10.05% of C# online submissions for Best Time to Buy and Sell Stock.
        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 1) return 0;

            int maxProfit = 0, start = 0, end = 1;
            while (end < prices.Length)
            {
                if (prices[start] < prices[end])
                    maxProfit = Math.Max(maxProfit, prices[end] - prices[start]);
                else start = end;
                end++;
            }
            return maxProfit;
        }

        // массив: [7, 1, 5, 3, 6, 4]
        //             1,       6,    --> 5

        // | Итерация | start | end | prices | MaxProfit |      Условие Выхода
        // + -------- + ----- + --- + ------ + --------- +         end >= 6
        // |    0     |   0   |  1  |  0, 0  |     0     |
        // |    1     |   1   |  2  |  7, 1  |     0     |
        // |    2     |   1   |  3  |  1, 5  |     4     |
        // |    3     |   1   |  4  |  1, 3  |     4     |
        // |    4     |   1   |  5  |  1, 6  |     5     |
        // |    5     |   1   |  6  |  1, 4  |     5     |
        // + -------- + ----- + --- + ------ + --------- +

    }
}
