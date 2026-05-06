//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class ArmStrong
//    {
//        static void Main()
//        {
//            Console.Write("Enter a number: ");
//            int num = int.Parse(Console.ReadLine());
//            int sum = 0, temp, remainder;
//            temp = num;

//            while (num > 0)
//            {
//                remainder = num % 10;
//                sum += remainder * remainder * remainder;
//                num /= 10;
//            }

//            if (temp == sum)
//            {
//                Console.WriteLine("The number is an Armstrong number.");
//            }
//            else
//            {
//                Console.WriteLine("The number is not an Armstrong number.");
//            }

//        }
//    }
//}
