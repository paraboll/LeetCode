using System;
using System.Collections.Generic;

namespace AddressBook
{
    public class SolvingTheProblem
    {
        public Dictionary<string, Queue<string>> CallNumbers(string[,] callNumbers)
        {
            var _callNumbers = new Dictionary<string, Queue<string>>();

            for (int i = 0; i < callNumbers.GetLength(0); i++)
            {
                if (!_callNumbers.ContainsKey(callNumbers[i, 0])) //если имя в словаре уже есть.
                {
                    _callNumbers.Add(callNumbers[i, 0], new Queue<string>(5));
                }

                if(_callNumbers[callNumbers[i, 0]].Count < 5)
                {
                    _callNumbers[callNumbers[i, 0]].Enqueue(callNumbers[i, 1]);
                } 
            }

            return _callNumbers;
        }
    }
}
