//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
   


    
//        /*
//         * GENERIC CLASS:
//         * when we are implemented generics in class level which is calle d as generic class..
//         * 
//         * syntax:
//         * class <classname> <T>
//         * {
//         * generic members
//         * non generic members.
//         * In case of generic class at the time of creating object we will decide 
//         * the type that object is called generic object.
//         * we cannot create a normal object for generic class.
//         * According for every time need to create an generic object.
//         * using generic object we can invoke  non generic methods.
//         * syntax to define generic object.
//         * <classname><type><objectname >=new <classname><Type>();
//         * 
//         */
//        class myclass<T>
//        {
//            T a;
//            internal myclass(T a)
//            {
//                this.a = a;
//            }
//            internal void Display()
//            {
//                Console.WriteLine("value of a is " + a);
//            }
//        }
//    class NewClass<T>
//    {
//        T b;
//        public NewClass(T b)
//        {
//            this.b = b;
//        }
//        internal void MyDisplay()
//        {
//            Console.WriteLine("value of b is " + b);
//        }
//    }






//        internal class GenericClass
//    {
//            static void Main(string[] args)
//            {
//                NewClass<string> nstring = new NewClass<string>("Hello");
//                nstring.MyDisplay();
//                NewClass<int> nint = new NewClass<int>(500);
//                nint.MyDisplay();







//            //myclass<int> mint = new myclass<int>(100);
//            //mint.Display();
//            //myclass<string> mstring = new myclass<string>("Welcome");
//            //mstring.Display();
//            //myclass<double> mdouble = new myclass<double>(2500000);
//            //mdouble.Display();
//        }
//        }
//    }


