using System;
using System.IO;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var _answers = new int[] { 298, 2000, 0, 0, 42 }; // Убрать.
            using (StreamReader read = new StreamReader("TestData.txt"))//Убрать.
            {   //Убрать.
                //var setOfProductsCount = Convert.ToInt32(Console.ReadLine()); //Добавить.
                var setOfProductsCount = Convert.ToInt32(read.ReadLine()); //считываем количество считываний -- Убрать.

                for (int i = 0; i < setOfProductsCount; i++)
                {
                    //int[] prices = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray(); //Добавить.
                    int[] prices = read.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray(); //Убрать.

                    var sum = 0;
                    for (int j = 0; j < prices.Length; j++)
                    {
                        sum += prices[j];
                    }
                    
                    Console.WriteLine(sum);

                    if(_answers[i] == sum) Console.WriteLine($"{sum} - ok"); //Убрать.
                    else Console.WriteLine($"{sum} - no"); //Убрать.
                }
            }   //Убрать.
        }
    }
}
