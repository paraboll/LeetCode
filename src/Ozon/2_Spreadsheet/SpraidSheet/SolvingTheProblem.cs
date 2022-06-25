using System;

namespace SpraidSheet
{
    public static class SolvingTheProblem
    {
        //Счет столбца цели от 0.
        public static int[,] SpreadSheet(int[,] table, int[] target)
        {
            int rowCount = table.GetLength(0); // получаю длину строки.
            int[] col = new int[rowCount];

            for (int i = 0; i < target.Length; i++) //перебираю столбцы цели сортировки
            {
                if(target[i] < 0 || target[i] > rowCount)
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

        public static int[,] SortAllTable(int[,] table)
        {
            int colCount = table.GetLength(0);
            int rowCount = table.GetLength(1);

            int[] col = new int[rowCount];
            for (int i = 0; i < colCount; i++)
            {
                //build a column.
                for (int j = 0; j < rowCount; j++)
                    col[j] = table[j, i];

                //sort Column.
                Array.Sort(col);

                //Insert Column into table.
                for (int k = 0; k < col.Length; k++)
                {
                    table[k, i] = col[k];
                }
            }

            return table;
        }
    }
}
