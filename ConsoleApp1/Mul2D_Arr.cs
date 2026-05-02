//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Mul2D_Arr
//    {
//        static void Main()
//        {
//            int [,] a = new int[3, 4];
//            int totalProduct = 1;
//            Console.WriteLine("\n--- Input Data ---");
//            // Outer loop for rows
//            for (int i = 0; i < 3; i++)
//            {
//                // Inner loop for columns
//                for (int j = 0; j < 4; j++)
//                {
//                    Console.Write($"Enter value for position [{i},{j}]: ");
//                    a[i, j] = int.Parse(Console.ReadLine());
//                }
//            }
//            Console.WriteLine("\n--- Array Elements ---");
//            // Display the array in a grid format and calculate product
//            for (int i = 0; i < 3; i++)
//            {
//                for (int j = 0; j < 4; j++)
//                {
//                    Console.Write(a[i, j] + "\t");
//                    totalProduct *= a[i, j];
//                }
//                Console.WriteLine(); // New line after each row
//            }
//            Console.WriteLine("----------------------");
//            Console.WriteLine($"Total Product of all numbers: {totalProduct}"); 
//        }
//        }
//}
