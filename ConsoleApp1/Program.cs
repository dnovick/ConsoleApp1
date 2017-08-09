using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static int antiAnimal(string s)
        {
            int res = 0;

            switch(s)
            {
                case "dog":
                    res = 0;
                    break;
                case "cat":
                    res = 1;
                    break;
                case "cow":
                    res = 2;
                    break;
                case "horse":
                    res = 3;
                    break;
                case "zebra":
                    res = 4;
                    break;
                case "snake":
                    res = 5;
                    break;
                case "llama":
                    res = 6;
                    break;
                case "predator":
                    res = 100;
                    break;
                default:
                    res = 1000;
                    break;
            };

            return res;

        }
        static int myadd(int a, int b)
        {
            return a + b;
        }

        static string animal(int n)
        {
            string s;
          
            switch (n)
            {
                case 0:
                    s = "dog";
                    break;
                case 1:
                    s = "cat";
                    break;
                case 2:
                    s = "cow";
                    break;
                case 3:
                    s = "horse";
                    break;
                case 4:
                    s = "zebra";
                    break;
                case 5:
                    s = "snake";
                    break;
                case 6:
                    s = "llama";
                    break;
                case 100:
                case 101:
                case 102:
                case 103:
                case 104:
                case 105:
                    s = "predator";
                    break;
                default:
                    s = "xenomorph";
                    break;
            };

            return s;

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

            for (int j = 0; j < 9; j++ )
            {
                Console.WriteLine(String.Format("The animal is {0}", animal(j)));
            }

            int num = 5;

            if (antiAnimal(animal(num)) == num)
            {
                Console.WriteLine("Test paaed");
            }
            else
            {
                Console.WriteLine("Test failed.");
            }

            Console.WriteLine("Bye bye.");

            

        }
    }
}
