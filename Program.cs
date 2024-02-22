using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanhArray3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;
            int[] array;
            do
            {
                Console.Write("Size: ");
                size = int.Parse(Console.ReadLine());
                if(size >10)
                {
                    Console.WriteLine("Size should not exceed 10");
                }
            } while (size > 10);

            array = new int[size];
            int i = 0;
            while (i < array.Length)
            {
                Console.Write("Enter element " + (i+1) + " : ");
                array[i] = int.Parse(Console.ReadLine());
                i++;
            }
            Console.Write("Array list: ");
            for(int j  = 0; j < array.Length; j++)
            {
                Console.Write(array[j] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            int max = array[0];
            int index = 1;
            for (int j = 0;j < array.Length; j++)
            {
                if (array[j] > max)
                {
                    max = array[j];
                    index = j+1;
                }
            }
            Console.WriteLine();
            Console.WriteLine("The largest number is " + max + ", at position " + index);
            Console.ReadKey();
        }

    }
}
