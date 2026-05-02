//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Jagged_Dynamic
//    {
//        static void Main()
//        {
//            // 1. Ask for the number of rows (the outer array size)
//            Console.Write("Enter the number of rows: ");
//            int rows = int.Parse(Console.ReadLine());

//            // Initialize the outer array
//            int[][] jaggedArray = new int[rows][];

//            // 2. Loop through each row to define its column size and take input
//            for (int i = 0; i < rows; i++)
//            {
//                Console.Write($"\nEnter the number of columns for row {i}: ");
//                int cols = int.Parse(Console.ReadLine());

//                // Initialize the inner array for this specific row
//                jaggedArray[i] = new int[cols];

//                for (int j = 0; j < cols; j++)
//                {
//                    Console.Write($"Enter element for row {i}, column {j}: ");
//                    jaggedArray[i][j] = int.Parse(Console.ReadLine());
//                }
//            }

//            // 3. Display the jagged array
//            Console.WriteLine("\n--- Your Jagged Array ---");
//            for (int i = 0; i < jaggedArray.Length; i++)
//            {
//                Console.Write($"Row {i}: ");
//                for (int j = 0; j < jaggedArray[i].Length; j++)
//                {
//                    Console.Write(jaggedArray[i][j] + " ");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}
