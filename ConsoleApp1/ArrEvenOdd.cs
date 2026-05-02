//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class ArrEvenOdd
//    {
//        static void Main()
//        {
//            int[] arr = new int[10];
//            Console.WriteLine("Enter 10 Integer Number");
//            for (int i = 0; i < arr.Length; i++)
//            {
//                try
//                {
//                    arr[i] = int.Parse(Console.ReadLine());
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine(ex.Message);
//                }
//            }
//            Console.WriteLine("Even Numbers in the Array:");
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i] % 2 == 0)
//                    Console.Write(arr[i] + " ");
//            }
//            Console.WriteLine("\nOdd Numbers in the Array:");
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i] % 2 != 0)
//                    Console.Write(arr[i] + " ");


//            }
//        }
//    }
//}
