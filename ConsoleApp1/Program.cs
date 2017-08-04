using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
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

            Console.WriteLine("Bye bye.");

        }
    }
}
