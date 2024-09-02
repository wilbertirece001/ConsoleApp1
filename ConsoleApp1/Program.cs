using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intVar;
            double doubleVar;
            char charVar;
            string stringVar;
            bool boolVar;
            int num1, num2;

            intVar = 1;
            doubleVar = 2.3;
            charVar = 'a';  
            stringVar = "hello";
            boolVar = false;
            num1 = 1;
            num2 = 2;


            Console.WriteLine("Integer Var:" + intVar);
            Console.WriteLine("double Var:" + doubleVar);
            Console.WriteLine("char Var:" + charVar);
            Console.WriteLine("String Var:" + stringVar);
            Console.WriteLine("Bool Var: "+ boolVar);

            Console.ReadKey();
        }
    }
}
