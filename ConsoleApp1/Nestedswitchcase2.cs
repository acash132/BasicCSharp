//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Nestedswitchcase2
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter your marks");
//            sbyte a = sbyte.Parse(Console.ReadLine());
//            switch (a > 45)//Outer Switch Block
//            {
//                case true:
//                    Console.WriteLine("Outer switch is executed");
//                    Console.WriteLine(a + " is a Pass Score");
//                    switch (a > 90)//Inner Switch block
//                    {

//                        case true:
//                            Console.WriteLine("Inner switch is executed");
//                            Console.WriteLine(a + " is a Distinction Score");
//                            break;
//                        case false:
//                            Console.WriteLine("Inner switch is executed");
//                            Console.WriteLine(a + " is Not a Distinction score");
//                            break;

//                    }
//                    break;
//                case false:
//                    Console.WriteLine("Outer switch is executed");
//                    Console.WriteLine(a + " is a Fail Score");
//                    switch (a < 10)//Inner Switch Block
//                    {

//                        case true:
//                            Console.WriteLine("Inner switch is executed");
//                            Console.WriteLine(a + " is a Single Digit score");
//                            break;
//                        case false:
//                            Console.WriteLine("Inner switch is executed");
//                            Console.WriteLine(a + " is a Double Digit Score");
//                            break;

//                    }
//                    break;


//            }


//        }
//    }
//}
