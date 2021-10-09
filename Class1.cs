using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    class Class1
    {
       public void CheckAutoMorpicNumber()
        {
            Console.WriteLine("Enter the number to check Automorphic or not");
            int number = Convert.ToInt32(Console.ReadLine());
            int squre = number * number;

            Console.WriteLine( "squre of " +number +" = " +squre);

            if (squre % 10 == number % 10)
            {
                Console.WriteLine("Automorphic number");
            }
            else
            {
                Console.WriteLine("not Automorphic number");
            }
            Console.ReadLine();
        }
    }
}
