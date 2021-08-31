using System;

namespace EnhanceLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print array:");

            // creating an array
            int[] a_array = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            // foreach loop begin
            // it will run till the
            // last element of the array
            foreach (int items in a_array)
            {
                Console.WriteLine(items);
            }
        }
    }
}
