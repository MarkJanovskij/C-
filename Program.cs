// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using static System.Console;

namespace HelloWorldConsoleApp
{
    class Program
    {
        /// <summary>
        /// Testing WriteLine
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            WriteLine("Hello, World I am Mark Janovskij");
            ReadKey();
            TestWriteMethod();
        }






        /// <summary>
        /// Testing Write
        /// </summary>
        /// <param name="arg"></param>
        static void TestWriteMethod()
        {
            Write("Hello ");
            Write("WORLD ");
            Write("!!!! ");
            ReadKey();
        }
    }
}