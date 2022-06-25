using System;
using System.Collections.Generic;

namespace AmountToBePaid
{
    public class SolvingTheProblem
    {
        public static int ProductSum(int[] prices)
        {
            var dictionary = new Dictionary<int, int>();

            for(int i = 0; i < prices.Length; i++)
            {
                var key = prices[i];
                if (dictionary.ContainsKey(key))
                {
                    dictionary[key] = ++dictionary[key];
                }
                else
                {
                    dictionary.Add(key, 1);
                }
            }

            int sum = 0;
            foreach(var item in dictionary)
            {
                sum += (item.Value - item.Value / 3) * item.Key;
            }

            return sum;
        } 
    }
}
