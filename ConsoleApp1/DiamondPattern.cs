//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class DiamondPattern
//    {
//        static void Main() {
//            Console.WriteLine("Enter the number of rows: ");
//            int rows = int.Parse(Console.ReadLine());
//            for (int i = 0; i < rows; i++)
//            {
//                for (int j = 0; j < rows - i - 1; j++)
//                {
//                    Console.Write(" ");
//                }
//                for (int k = 0; k < 2 * i + 1; k++)
//                {
//                    Console.Write("*");
//                }
//                Console.WriteLine();
//            }
//            for (int i = rows - 2; i >= 0; i--)
//            {
//                for (int j = 0; j < rows - i - 1; j++)
//                {
//                    Console.Write(" ");
//                }
//                for (int k = 0; k < 2 * i + 1; k++)
//                {
//                    Console.Write("*");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}
