//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class ArrCountEvenOdd
//    {
//        static void Main()
//        { 
//            int[] arr = new int[10];
//            int evenCount = 0;
//            int oddCount = 0;

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
//                    evenCount++;
//                else
//                    oddCount++;
//            }

//            Console.WriteLine($"Even Numbers Count: {evenCount}");
//            Console.WriteLine($"Odd Numbers Count: {oddCount}");
//        }
//    }
//}
