//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class NestedSwitchCase3
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter your Team Points");
//            sbyte a = sbyte.Parse(Console.ReadLine());
//            switch (a >= 14)//Outer Switch Block
//            {
//                case true:
//                    Console.WriteLine("Outer switch is executed");
//                    Console.WriteLine(a + " is a PlayOFF hopeful situation");
//                    switch (a > 18)//Inner Switch block
//                    {

//                        case true:
//                            Console.WriteLine("Inner switch is executed");
//                            Console.WriteLine(a + " is a Top Contender Points");
//                            break;
//                        case false:
//                            Console.WriteLine("Inner switch is executed");
//                            Console.WriteLine(a + "  points means Qualification Depends on NRR");
//                            break;

//                    }
//                    break;
//                case false:
//                    Console.WriteLine("Outer switch is executed");
//                    Console.WriteLine(a + " is a Slim To No chance Points");
//                    switch (a <= 9)//Inner Switch Block
//                    {

//                        case true:
//                            Console.WriteLine("Inner switch is executed");
//                            Console.WriteLine(a + " is a Out Of Contention Points");
//                            break;
//                        case false:
//                            Console.WriteLine("Inner switch is executed");
//                            Console.WriteLine(a + " is a Mid Table Points");
//                            break;

//                    }
//                    break;


//            }


//        }
//    }
//}
