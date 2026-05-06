//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class ArrBigEvenOdd
//    {
//        static void Main()
//        {
//            int[] arr = new int[10];
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
//            int maxEven = int.MinValue;
//            int maxOdd = int.MinValue;
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i] % 2 == 0 && arr[i] > maxEven)
//                    maxEven = arr[i];
//                else if (arr[i] % 2 != 0 && arr[i] > maxOdd)
//                    maxOdd = arr[i];
//            }
//            if (maxEven != int.MinValue)
//                Console.WriteLine($"Largest Even Number: {maxEven}");
//            else
//                Console.WriteLine("No Even Number found.");
//            if (maxOdd != int.MinValue)
//                Console.WriteLine($"Largest Odd Number: {maxOdd}");
//            else
//                Console.WriteLine("No Odd Number found.");
//        }
//    }
//}
