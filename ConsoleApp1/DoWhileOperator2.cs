//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class DoWhileOperator2
//    {
//        static void Main()
//        {
//            Console.Write("Enter a Number To Perform Operation: ");
//            sbyte num = sbyte.Parse(Console.ReadLine());
//            string choice = "yes";

//            do
//            {
//                Console.WriteLine("\nChoose Below Options");
//                Console.WriteLine("1. Positive/Negative");
//                Console.WriteLine("2. Even/Odd");
//                Console.WriteLine("3. Square");
//                Console.WriteLine("4. Cube");
//                Console.Write("Pls Enter Your Option: ");
//                int option = int.Parse(Console.ReadLine());

//                switch (option)
//                {
//                    case 1:
//                        if (num > 0)
//                            Console.WriteLine(num + " is Positive Number.");
//                        else
//                            Console.WriteLine(num + " is Negative  Number.");

//                        break;
//                    case 2:
//                        if (num % 2 == 0)
//                            Console.WriteLine(num + " is Even Number.");
//                        else
//                            Console.WriteLine(num + " is Odd Number.");

//                        break;
//                    case 3:
//                        Console.WriteLine("Square of a Number is " + (num * num));
//                        break;
//                    case 4:
//                        Console.WriteLine("Cube of a Number is " + (num * num * num));
//                        break;
//                    default:
//                        Console.WriteLine("Pls Enter Valid Option");
//                        break;
//                }

//                Console.Write("\nDo you want Continue? (yes/no): ");
//                choice = Console.ReadLine().ToLower();

//            } while (choice == "yes");
//        }
//    }
//}
