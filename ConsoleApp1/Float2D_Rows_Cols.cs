//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Float2D_Rows_Cols
//    {
//        static void Main()
//        {
//            Console.WriteLine("Enter the number of rows:");
//           int r = int.Parse(Console.ReadLine());

//            Console.WriteLine("Enter the number of columns:");
//            int c = int.Parse(Console.ReadLine());

//            float[,] a = new float[r, c];

//            Console.WriteLine("\n--- Input Data ---");
//            for (int i = 0; i < r; i++)
//            {
//                for (int j = 0; j < c; j++)
//                {

//                    a[i, j] = float.Parse(Console.ReadLine());
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
