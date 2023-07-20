using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            for (int i = 0; i < 1000; i++) {

                if (counter % 100 == 0)
                    Console.WriteLine($"files analyzed - {counter}");

                counter++;
            }
        }
    }
}
