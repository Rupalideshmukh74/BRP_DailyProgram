using System;
using System.Collections.Generic;


namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter size of an Array : ");
            int size = int.Parse(Console.ReadLine());

            int[] a = new int[size];

            Console.WriteLine("Array Elements Are : ");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("After Adding new Element : ");
            int pos = 3;
            int element = 100;
            for (int i = a.Length-1; i >pos-1; i--)
            {
                a[i] = a[i - 1];
            }
            a[pos - 1] = element;
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]+" ");
            }

        }

    }
}
    
