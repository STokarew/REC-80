using System;
using System.Linq;
using System.Collections.Generic;
namespace REC_80
{
    class Program
    {
        private static int[] RandomUniqueMatrix(int[] Arr )
        {
            int[] UniqueRandomArr = new int[Arr.GetLength(0)];
            Random Rnd = new Random();
            List<int> list = Enumerable.Range(1, UniqueRandomArr.GetLength(0)).OrderBy(Num => Rnd.Next()).ToList();
            for (int i = 0; i < UniqueRandomArr.GetLength(0); i++)
            {
                UniqueRandomArr[i] = list[i];
            }
            return UniqueRandomArr;
        }
        static void PrintMatrix(int[] Arr)
        {
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                    Console.Write(Arr[i] + "\t");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов матрицы: ");
            int ArrLength = int.Parse(Console.ReadLine());
            int[] Arr = new int[ArrLength];
            Arr = RandomUniqueMatrix(Arr);
            PrintMatrix(Arr);
            Console.ReadKey();
        }
    }
}
