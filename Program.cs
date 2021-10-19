using System;
using System.Collections.Generic;


namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, a = 0, b = 1, c;
            Console.Write("enter limit : ");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i <num; i++)
            {
                Console.WriteLine(a+ " ");
                c = a + b;
                a = b;
                b = c;
            }

        }


        }
    }
