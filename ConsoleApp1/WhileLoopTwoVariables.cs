//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class WhileLoopTwoVariables
//    {
//        static void Main()
//        {
//            Console.WriteLine("Income Tax Portal Login");

//            Console.WriteLine("Enter PAN Card Number: ");
//            string pan = Console.ReadLine();

//            Console.WriteLine("Enter 6-digit PIN: ");
//            int pin = int.Parse(Console.ReadLine());


//            while (pan != "ABCDE1234F" || pin != 556677)
//            {

//                Console.WriteLine("Please Enter Valid Credentials");

//                Console.Write("Enter PAN Card Number: ");
//                pan = Console.ReadLine();

//                Console.Write("Enter 6-digit PIN: ");
//                pin = int.Parse(Console.ReadLine());
//            }

//            Console.WriteLine("\nWelcome to your Dashboard!!");
//        }
//    }
//}
