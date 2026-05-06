//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class SquareCrossDiagonalPattern
//    {
//        static void Main()
//        {
//            Console.Write("Enter the number of rows: ");
//            int rows = int.Parse(Console.ReadLine());
//            for (int i = 1; i <= rows; i++)
//            {
//                for (int j = 1; j <= rows; j++)
//                {
//                    if (i == 1 || i == rows || j == 1 || j == rows || i == j || j == (rows - i + 1))
//                        Console.Write("*");
//                    else
//                        Console.Write(" ");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}
