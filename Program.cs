using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uzunlugu daxil edin");
            int.TryParse(Console.ReadLine(), out int size);
            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            
            new_array(ref numbers, 1, 2, 3, 4, 5);

            foreach (int i in numbers) { Console.WriteLine(i);}


        }
        static void new_array(ref int[] numbers, params int[] Second_array)
        {
            //foreach (int t in Second_array)
            //{
            //    Console.WriteLine(t);
            //}
            int[] array_3 = new int[numbers.Length + Second_array.Length];
            //Console.WriteLine(array_3.Length);
            for(int i=0; i<numbers.Length; i++)
            {
                array_3[i] = numbers[i];
                //Console.WriteLine(i);
                //Console.WriteLine(array_3[i]);
                //Console.WriteLine(array_3);
                
            }
            for (int x = numbers.Length; x < array_3.Length; )
            {
                for (int s = 0; s < Second_array.Length; s++)
                {
                    array_3[x] = Second_array[s];
                    x++;
                }

            }
            //Console.WriteLine(array_3);


          numbers = array_3;
        }


            

    }
    
}