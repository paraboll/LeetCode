using System;
using System.Linq;

namespace SpreadSheetConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var setCount = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < setCount; i++)
            {
                Console.ReadLine(); //пропуск пустой строки.
                int[] arraySizes = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                var matrix = new int[arraySizes[0], arraySizes[1]];

                for(int j=0; j< arraySizes[0]; j++)
                {
                    int[] arrayValues = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                    for(int k = 0; k < arrayValues.Length; k++)
                    {
                        matrix[j, k] = arrayValues[k];
                    }
                }

                var clickCount = Convert.ToInt32(Console.ReadLine());
                int[] target = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

                var sortMatrix = SortSpreadSheet(matrix, target);
            }
        }

        //Счет столбца цели от 0.
        public static int[,] SortSpreadSheet(int[,] table, int[] target)
        {
            int rowCount = table.GetLength(0); // получаю длину строки.
            int[] col = new int[rowCount];

            for (int i = 0; i < target.Length; i++) //перебираю столбцы цели сортировки
            {
                if (target[i] < 0 || target[i] > rowCount)
                {
                    continue;
                }

                //build a column.
                for (int j = 0; j < rowCount; j++)
                    col[j] = table[j, target[i]];

                //sort Column.
                Array.Sort(col);

                //Insert Column into table.
                for (int k = 0; k < col.Length; k++)
                {
                    table[k, target[i]] = col[k];
                }
            }

            return table;
        }
    }
}
