using System;
using System.Collections.Generic;
using System.Linq;

namespace AmountToBePaidConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var setOfProductsCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < setOfProductsCount; i++)
            {
                var priceCount = Convert.ToInt32(Console.ReadLine());
                int[] prices = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

                var dictionary = new Dictionary<int, int>();
                for (int j = 0; j < prices.Length; j++)
                {
                    var key = prices[j];
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
                foreach (var item in dictionary)
                {
                    sum += (item.Value - item.Value / 3) * item.Key;
                }

                Console.WriteLine(sum);
            }
        }
    }
}
