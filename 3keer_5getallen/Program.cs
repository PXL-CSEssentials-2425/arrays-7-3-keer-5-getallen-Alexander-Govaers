using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace _3keer_5getallen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[5];
            int[] array2 = new int[5];
            int[] array3 = new int[5];


            Random rnd = new Random();

            Console.WriteLine("****SOM VAN GETALLEN UIT 2 ARRAYS**** \n");

            Console.Write("Array1 ==> ");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($" \t {array1[i] = rnd.Next(0, 10)}");
            }


            Console.Write("\nArray2 ==> ");
            for (int i = 0;i < array2.Length; i++)
            {
                Console.Write($" \t {array2[i] = rnd.Next(0, 10)}");
            }

            Console.Write("\nArray3 ==> ");
            for (int i = 0; i < array3.Length; i++)
            {
                Console.Write($" \t {array3[i] = (array2[i] + array1[i])}");
            }
           
            Console.ReadLine();
            

        }
    }
}
