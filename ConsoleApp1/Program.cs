using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int myadd(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Here are my args!");

            int i = 0;

            foreach (string arg in args)
            {
                Console.WriteLine(String.Format("Argument #{0} = {1}",i, arg));
                i++;
            }

            if (args[0] == "chinese")
            {
                Console.WriteLine("I like Chinese food. You know that it's true.");
            }

            int n = myadd(5, 6);

            Console.WriteLine(String.Format("5 + 6 = {0}", n));

            Console.WriteLine("Bye bye.");

        }
    }
}
