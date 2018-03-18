using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Start computation.
                Example();

                Console.WriteLine("Start typing:");
                // Handle user input.
                string result = Console.ReadLine();
                Console.WriteLine("You typed: " + result);
            }
        }


        static async void Example()
        {
            var t = await Task.Run(() => Allocate());
            Console.WriteLine("Compute: " + t);
        }

        static int Allocate()
        {
            // Compute total count of digits in strings.
            int size = 0;
            for (int z = 0; z < 100; z++)
            {
                for (int i = 0; i < 100000; i++)
                {
                    var value = i.ToString();
                    size += value.Length;
                }
            }
            return size;
        }
    }
}
