using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AmountToBePaidConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var _answers = new int[] { 22, 22, 10000, 12, 40000, 1100}; //Убрать.
            using (StreamReader read = new StreamReader("TestData.txt"))//Убрать.
            {   //Убрать.
                //var setOfProductsCount = Convert.ToInt32(Console.ReadLine()); //Добавить.
                var setOfProductsCount = Convert.ToInt32(read.ReadLine()); //считываем количество считываний -- Убрать.

                for (int i = 0; i < setOfProductsCount; i++)
                {
                    //var priceCount = Convert.ToInt32(Console.ReadLine());   //Добавить.
                    var priceCount = Convert.ToInt32(read.ReadLine());          //Убрать.
                    //int[] prices = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray(); //Добавить.
                    int[] prices = read.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray(); //Убрать.

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

                    if (_answers[i] == sum) Console.WriteLine($"{sum} - ok"); //Убрать.
                    else Console.WriteLine($"{sum} - no"); //Убрать.
                }

            }   //Убрать.
        }
    }
}
