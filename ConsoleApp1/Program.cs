using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int add(int a, int b)
        {
            return a + b;

        }

        static string chop(string s)
        {
            
            return s.Substring(1);
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            Console.WriteLine("The answer is: {0}.", chop("Baruch"));


            Console.WriteLine("Bye bye.");

            

        }
    }
}
