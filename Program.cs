using System;
using System.Collections.Generic;


namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            
            
            int[] arr ={36,29,15,5,45};          
            

            
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-1-i ; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

                }
                
               
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
           

        }

    }
}
    
