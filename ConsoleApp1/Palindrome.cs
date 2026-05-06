//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Palindrome
//    {
//        static void Main()
//        { 
//            int rem, sum = 0, temp;
           

//            Console.Write("Enter a number: ");
//            int num = int.Parse(Console.ReadLine());
//            temp = num;

//            while (num > 0)
//            {
//                rem = num % 10;
//                sum = (sum * 10) + rem;
//                num = num / 10;
//            }

//            if (temp == sum)
//            {
//                Console.WriteLine("The number is a palindrome.");
//            }
//            else
//            {
//                Console.WriteLine("The number is not a palindrome.");
//            }

//        }
//    }
//}
