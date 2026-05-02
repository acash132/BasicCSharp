//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Jagged_Play
//    {
//        static void Main()
//        { 
//            Console.WriteLine("Enter the number of rows: ");
//            int rows = int.Parse(Console.ReadLine());
//            int[][] a= new int[rows][];
//            for (int i = 0; i < rows; i++)
//            { 
//                Console.WriteLine($"Enter the number of columns for row {i}: ");
//                int cols = int.Parse(Console.ReadLine());
//                a[i] = new int[cols];// Initialize the inner array for this specific row
//                for (int j = 0; j < cols; j++)
//                {
//                    Console.WriteLine($"Enter element for row {i}, column {j}: ");
//                    a[i][j] = int.Parse(Console.ReadLine());
//                }

//            }
//            Console.WriteLine("The jagged array is: ");
//            for (int i = 0; i < a.Length; i++)
//            {
//                Console.Write($"Row {i}: ");
//                for (int j = 0; j < a[i].Length; j++)
//                {
//                    Console.Write(a[i][j] + " ");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}
