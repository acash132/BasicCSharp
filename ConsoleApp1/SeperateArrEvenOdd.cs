//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class SeperateArrEvenOdd
//    {
//        static void Main()
//        {
//            int[] arr = new int[10];
//            int[] evenArr = new int[arr.Length];
//            int[] oddArr = new int[arr.Length];
//            int evenIndex = 0;
//            int oddIndex = 0;
//            Console.WriteLine("Enter 10 Integer Numbers:");
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
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i] % 2 == 0)
//                {
//                    evenArr[evenIndex++] = arr[i];
//                }
//                else
//                {
//                    oddArr[oddIndex++] = arr[i];
//                }
//            }
//            Console.WriteLine("Even Numbers in the Array:");
//            for (int i = 0; i < evenIndex; i++)
//            {
//                Console.Write(evenArr[i] + " ");
//            }
//            Console.WriteLine("\nOdd Numbers in the Array:");
//            for (int i = 0; i < oddIndex; i++)
//            {
//                Console.Write(oddArr[i] + " ");

//            }
//        }
//    }
//}
