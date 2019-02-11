using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If you want to draw square");
            Console.WriteLine("Write what size square you want:");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = x;

            for (int i = 0; i < x; i++)
            {
                for (int r = 0; r < x; r++)
                {
                    Console.Write(" ");

                }

                for (int j = 0; j < x; j++)
                {
                    Console.Write("*");
                }
                Console.Write(" ");
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
