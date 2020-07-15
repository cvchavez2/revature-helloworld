// using System;  namespace

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello Carlos!");
            string name = System.Console.ReadLine();
            int a = 7;
            int b = 2;
            System.Console.WriteLine(a+b);
            System.Console.WriteLine("my name is: " + name);
            test();
        }
        static void test(){
          System.Console.WriteLine("test method");
        }
    }
}
