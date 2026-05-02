//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class LP14_Fibanocii
//    {
//        static void Main()
//        {
//            Console.WriteLine("Enter the Number to calculate Fibanocii Series");
//            int n = Convert.ToInt32(Console.ReadLine());
//            int a = 0, b = 1, c=0;
//            int sum=0,count = 0;
//            while(a<=n)
//            {
//                Console.Write(a+" ");
//                c = a + b;
//                a = b;
//                b = c;
//                sum= sum + a;
//                count++;
//            }
//            Console.WriteLine("\nThe Sum of the Fibanocii Series is " + sum);
//            Console.WriteLine("The Count of the Fibanocii Series is " + count);


//        }
//    }
//}
