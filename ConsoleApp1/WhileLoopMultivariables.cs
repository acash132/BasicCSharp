//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class WhileLoopMultivariables
//    {
//        static void Main()
//        {
//            Console.WriteLine("Bank Transaction Channel Access");

//            Console.WriteLine("Enter Account Number: ");
//            string accNum = Console.ReadLine();

//            Console.WriteLine("Enter Login Pin: ");
//            int Lpin = int.Parse(Console.ReadLine());

//            Console.WriteLine("Enter Transaction Pin: ");
//            int Tpin = int.Parse(Console.ReadLine());

//            Console.WriteLine("Enter Captcha Text:");
//            string captcha = Console.ReadLine();




//            while (accNum != "AX146" || Lpin != 146 || Tpin != 132 || captcha != "Vibe")
//            {
//                Console.WriteLine("Security Alert!! Pls Enter Valid Details.");

//                Console.WriteLine("Re-enter Account Number: ");
//                accNum = Console.ReadLine();

//                Console.WriteLine("Re-enter Login PIN: ");
//                Lpin = int.Parse(Console.ReadLine());

//                Console.WriteLine("Enter Transaction Pin: ");
//                Tpin = int.Parse(Console.ReadLine());

//                Console.Write("Enter Captcha Text:");
//                captcha = Console.ReadLine();


//            }

//            Console.WriteLine("\nWelcome To Your Transaction Channel");
//        }
//    }
//}
