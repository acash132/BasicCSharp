//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class DoWhile_Arthimatic_Operators
//    {
//        static void Main()
//        {
//            Console.WriteLine("Enter First Number");
//            sbyte a=sbyte.Parse(Console.ReadLine());
//            Console.WriteLine("Enter Second Number");
//            sbyte b = sbyte.Parse(Console.ReadLine());
//            String ans = "yes";
//            do
//            {
//                Console.WriteLine("1.Addition");
//                Console.WriteLine("2.Subtraction");
//                Console.WriteLine("3.Multiplication");
//                Console.WriteLine("4.Division");
//                Console.WriteLine("Pls Enter Your Option");
//                sbyte option = sbyte.Parse(Console.ReadLine());
//                switch (option)
//                {
//                    case 1:
//                        Console.WriteLine("Addition of Two Numbers is :" + (a + b));
//                        break;
//                    case 2:
//                        Console.WriteLine("Subtraction of Two Numbers is :" + (a - b));
//                        break;
//                    case 3:
//                        Console.WriteLine("Multiplication of Two Numbers is :" + (a * b));
//                        break;
//                    case 4:
//                        Console.WriteLine("Division of Two Numbers is :" + (a/b));
//                        break;

//                    default:
//                        Console.WriteLine("please Enter Valid Option");
//                        break;
//                }
//                Console.WriteLine("Do You Want to continue (Yes/No)");
//                ans=Console.ReadLine();

                


//            }while (ans == "yes");
        


//        }
//    }
//}
