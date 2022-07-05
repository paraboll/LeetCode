using System;
using System.Collections.Generic;
using System.IO;

namespace AddressBookConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var _answers = new string[] {

                "ivan: 1 1234567 " +
                "sergey: 2 0000000 0000001",

                "a: 5 1000004 1000007 1000006 1000001 1000002",

                "abcdefgh: 1 9876543",

                "a: 1 0000004" +
                "aa: 1 0000001" +
                "aaa: 1 0000002" +
                "aaaa: 1 0000003",

                "a: 5 0000013 0000001 0000009 0000011 0000007" +
                "b: 5 0000002 0000004 0011111 0001111 0000003" }; //УБРАТЬ.

            using (StreamReader read = new StreamReader("TestData.txt"))//Убрать.
            {   //Убрать.

                //var setCount = Convert.ToInt32(Console.ReadLine()); //Добавить.
                var setCount = Convert.ToInt32(read.ReadLine()); //УБРАТЬ.
                for (int i = 0; i < setCount; i++)
                {
                    var _callNumbers = new Dictionary<string, Queue<string>>();

                    //var countData = Convert.ToInt32(Console.ReadLine()); //Добавить.
                    var countData = Convert.ToInt32(read.ReadLine()); //УБРАТЬ.
                    for (int j = 0; j < countData; j++)
                    {
                        var data = read.ReadLine().Split(' ');
                        if (!_callNumbers.ContainsKey(data[0])) //если имя в словаре уже есть.
                        {
                            _callNumbers.Add(data[0], new Queue<string>(5));
                        }

                        if (_callNumbers[data[0]].Count < 5)
                        {
                            _callNumbers[data[0]].Enqueue(data[1]);
                        }
                    }

                    foreach (var item in _callNumbers)
                    {
                        Console.WriteLine($"{item.Key}: {item.Value.Count} {item.Value.Dequeue()}");
                    }
                    Console.WriteLine();
                }
               

            }   //Убрать.

        }
    }
}
