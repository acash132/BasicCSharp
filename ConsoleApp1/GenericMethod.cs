//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class GenericMethod
//    {
       
//        /*
//         * Generics: Introduced in 2.0
//         * generics is similar like c++ templates.
//         * generics was introduced with .net framework .net 2.0
//         * generics will allow the programmer to decide parameters type at the time of
//         * consumption that is in declaration we will
//         * declare it as a generic type and which can be consumed as int or float or
//         * char or string or double according to the requirement.
//         * In C#.net we can have generic varibale, generic property,generic constructor
//         * generic method,generic class.
//         * To implement generics we will use place holder
//         * operator(<>) will type parameter like <T>.
//         * 
//         * Generic Functions:
//         * when we implement generics on method or generic functions then we call it as 
//         * a generic function.
//         * syntax:
//         * <access modifier><return types><function name> ,T>(T <args1>,....<argn>)
//         * {
//         * }
//         * Note:we can declare static and instance memebrs as generic members.
//         */
//        class myclass
//        {
//            public void sum(int x) {
//                Console.WriteLine(x);
//            }
//            public void Add<T>(T a)
//            {
//                Console.WriteLine(a);
//            }
//            public void Sub<T>(T a, T b)
//            {
//                Console.WriteLine("value of a " + a + " value of b " + b);
//            }
//            public void Student<T, K>(T a, K b)
//            {
//                Console.WriteLine("value of a " + a + " value of b " + b);
//            }



//            //internal void Display<T>(T u)
//            //{
//            //    Console.WriteLine(u);
//            //}
//            //internal static void Show<T>(T d, T b)
//            //{
//            //    Console.WriteLine("value of d" + d + "value of b " + b);
//            //}
//            //internal void print<T, K>(T a, K b)
//            //{
//            //    Console.WriteLine(a + " " + b);
//            //}
//        }
//        internal class Program
//        {
//            static void Main(string[] args)
//            {
//                myclass objc = new myclass();
//                objc.sum(100);
//                objc.Add<int>(123);
//                objc.Add<string>("Hello");
//                objc.Sub<double>(1.2, 2.4);
//                objc.Student<string, int>("Jackson", 200);
//                objc.Student<int, string>(100, "Amy");




//                //obj.Display<int>(123);
//                //obj.Display<string>("Hello");
//                //obj.Display<bool>(false);
//                //obj.Display<double>(1.0);
//                //myclass.Show<int>(200, 400);
//                //myclass.Show<string>("Hello", "World");
//                //myclass.Show<double>(1.2, 2.4);
//                //obj.print<int, string>(100, "Amy");
//                //obj.print<string, int>("Jackson", 200);
//            }
//        }
//    }
//}

