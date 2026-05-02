//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class DoWhilePhoneModel
//    {
//        static void Main()
//        {
//            string Choice = "yes";

//            do
//            {
//                Console.WriteLine("\nWelcome to Mobile Store");
//                Console.WriteLine("1. iPhone 17 Pro");
//                Console.WriteLine("2. Samsung S24 Ultra");
//                Console.WriteLine("3. Moto Flip");
//                Console.WriteLine("4. OnePlus 12");
//                Console.Write("Select a model to see Price  ");
//                sbyte model = sbyte.Parse(Console.ReadLine());

//                switch (model)
//                {
//                    case 1:
//                        Console.WriteLine("iPhone 17 Pro Price is: 1,50,000 INR");
//                        break;
//                    case 2:
//                        Console.WriteLine("Samsung S24 Ultra Price is: 1,10,000 INR");
//                        break;
//                    case 3:
//                        Console.WriteLine("Moto flip Razor 60 Price is : 90,0000 INR");
//                        break;
//                    case 4:
//                        Console.WriteLine("OnePlus 12 Price is: 95000 INR");
//                        break;
//                    default:
//                        Console.WriteLine("Model not found in our Store.");
//                        break;
//                }

//                Console.Write("\nWould you like to view another model? (yes/no): ");
//                Choice = Console.ReadLine().ToLower();

//            } while (Choice == "yes");


//        }
//    }
//}
