//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class _2D_Rows_Col
//    {
//        static void Main()
//        {
//            Console.WriteLine("Enter the number of rows:");
//            int r = int.Parse(Console.ReadLine());

//            Console.WriteLine("Enter the number of columns:");
//            int c = int.Parse(Console.ReadLine());

//            int[,] a = new int[r, c];

//            Console.WriteLine("\n--- Input Data ---");
//            for (int i = 0; i < r; i++)
//            {
//                for (int j = 0; j < c; j++)
//                {
                    
//                    a[i, j] = int.Parse(Console.ReadLine());
//                }
//            }

//            Console.WriteLine("\nEntered Elements:");
//            for (int i = 0; i < r; i++)
//            {
//                for (int j = 0; j < c; j++)
//                {
//                    Console.Write(a[i, j] + "\t");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}
