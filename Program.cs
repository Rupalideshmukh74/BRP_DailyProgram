using System;
using System.Collections.Generic;


namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter size of Array : ");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int [size];
            Console.WriteLine("Array Elements Are : ");
            for (int i = 0; i <a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("After Sorting elements are : ");
            int temp;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length-1-i; j++)
                {
                    if (a[j] > a[j+1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }

                }

            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + " ");
            }
            


        }

    }
}
    
