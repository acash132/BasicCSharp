//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    /*
//     * Delegates are similar like c++ function pointers.
//     * To define a delegate we have to use delegate keyword,
//     * delegates are reference types.
//     * delegate can hold the address of function,
//     * using delegate object we can invoke a method without using
//     * method name.
//     * delegates are of two types:
//     * 1)single cast delegate
//     * 2)multicast delegate:
//     * 
//     * single cast delegate:it can hold the address of a single method.
//     * Multi cast delegate:It can hold the address of multiple methods.
//     * 
//     * Implementation of delegate concept can be divided into  follwing
//     * steps.
//     * step1 : Define a class
//     * step2 : Define a method
//     * step3 : Define a delegate.
//     * 
//     * <syntax>
//     * <accessmodifier> delegate <returntype> <delegatename>(<type> <arg1>,<type> <arg2>);
//     * delegate is a keyword.
//     * 
//     * step4: creating object for delegate and initializing the method name.
//     * <delegatename> <delegateobjname>=new <delefatename>(methodname);
//     * 
//     * step5 :Invoking the method by using delegate object.
//     * <delegateobjname()>;
//     * 
//     * Delegate are called as the function pointers becasue delegate declaration
//     * should follow the method declaration which is holding by the delegate
//     * object. that means method return type and signature should be same for
//     * delegate.
//     * Delegate can hold the address of static methods as well as instance methods.
//     * 
//     * 
//     */
//    class calculate
//    {
//        internal int add(int a, int b)
//        {
//            return a + b;
//        }
//    }
//    internal delegate int MyDelegate(int x, int y);
    
    
//    internal class Delegates1
//    {
//        static void Main()
//        {
//            calculate obj = new calculate();
//            MyDelegate delobj = new MyDelegate(obj.add);
//            int res = delobj(10, 20);
//            Console.WriteLine("Addition result is " + res);

//        }
//    }
//}
