using System;
using System.Linq;
using System.Collections.Generic;
namespace REC_80
{
    class Program
    {
        private static int[,] RandomUniqueMatrix(int n, int m)
        {
            int[,] ARR = new int[n, m];
            Random rnd = new Random();
            List<int> list = Enumerable.Range(1, n * m).OrderBy(x => rnd.Next()).ToList();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    ARR[i, j] = list[i * n + j];
                }
            }
            return ARR;
        }
        static void PrintMatrix(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write(m[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк матрицы: ");
            var Row = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов матрицы: ");
            var Column = int.Parse(Console.ReadLine());
            var ARR = RandomUniqueMatrix(Row, Column);
            PrintMatrix(ARR);
            Console.ReadKey();
        }
    }
}
