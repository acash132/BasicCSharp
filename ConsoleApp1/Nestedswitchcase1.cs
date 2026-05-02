//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Nestedswitchcase1
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter a Number");
//            sbyte a = sbyte.Parse(Console.ReadLine());
//            switch (a > 0)//Outer Switch Block
//            {
//                case true:
//                    Console.WriteLine("Outer switch is executed");
//                    Console.WriteLine(a + "is a positive number");
//                    switch (a % 2 == 0)//Inner Switch block
//                    {

//                        case true:
//                            Console.WriteLine("Inner switch is executed");
//                            Console.WriteLine(a + "is a Even number");
//                            break;
//                        case false:
//                            Console.WriteLine("Inner switch is executed");
//                            Console.WriteLine(a + "is an odd number");
//                            break;

//                    }
//                    break;
//                case false:
//                    Console.WriteLine("Outer switch is executed");
//                    Console.WriteLine(a + "is a negative number");
//                    switch (a % 2 == 0)//Inner Switch Block
//                    {

//                        case true:
//                            Console.WriteLine("Inner switch is executed");
//                            Console.WriteLine(a + "is an Even number");
//                            break;
//                        case false:
//                            Console.WriteLine("Inner switch is executed");
//                            Console.WriteLine(a + "is an odd number");
//                            break;

//                    }
//                    break;


//            }


//        }
//    }
//}
