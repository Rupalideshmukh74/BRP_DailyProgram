using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 10 == 7 || number % 7 == 0)
            {
                Console.WriteLine(" number is Buzz Number");
            }
            else
            {
                Console.WriteLine("number is Not a Buzz Number");
            }
            Class1 obj = new Class1();
            obj.CheckAutoMorpicNumber();

        }


    }
    }
