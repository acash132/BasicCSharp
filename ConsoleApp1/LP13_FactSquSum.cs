//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class LP13_FactSquSum
//    {
//        static void Main()
//        {
//            Console.WriteLine("Enter the Number to calculate Factorial of the Squares Sum");
//            int n=Convert.ToInt32(Console.ReadLine());
//            int fact= 1, sum=0;

//            for (int i = n; i>=1; i--)
//            {
//                for (int j = i; j >= 1; j--)
//                {
//                    fact=fact * j;

//                }
//                sum = sum + fact;
//                fact = 1;

//            }
//            Console.WriteLine("The Sum of the Factorials of the Squares of the  Numbers is " + sum);


//        }
//    }
//}
