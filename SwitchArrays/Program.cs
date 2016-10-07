using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array1 = new int[6, 8];
            PopulateArray(array1);
            PrintArray(array1);
            int[,] array2 = CopyArray(array1, 2, 0, 4, 6);
            PrintArray(array2);

            
            Console.WriteLine("Done!");
            Console.ReadLine();
        }

        private static int[,] CopyArray(int[,] array, int fromX, int fromY, int lengthX, int lengthY)
        {
            int[,] result = new int[lengthX, lengthY];
            for (int x = 0; x < result.GetLength(0); x++)
            {
                for (int y = 0; y < result.GetLength(1); y++)
                {
                    result[x, y] = array[x + fromX, y + fromY];
                }
            }
            return result;
        }

        private static int[,] PopulateArray(int[,] array)
        {
            var rdn = new Random(DateTime.Now.Millisecond);
            for (int x = 0; x < array.GetLength(0); x++)
            {
                for (int y = 0; y < array.GetLength(1); y++)
                {
                    array[x, y] = rdn.Next(0, 10000);
                }
            }
            return array;
        }

        private static void PrintArray(int[,] array)
        {
            for (int x = 0; x < array.GetLength(0); x++)
            {
                for (int y = 0; y < array.GetLength(1); y++)
                {
                    Console.Write($"{FormatTo(array[x, y], 4)} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        private static string FormatTo(int value, int digits)
        {
            string result = value.ToString();
            digits -= result.Length;
            while (digits > 0)
            {
                result = " " + result;
                digits--;
            }
            return result;
        }
    }
}
