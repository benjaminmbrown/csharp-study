using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            // if (args[0]) { string name = args[0]; }
            Console.WriteLine("Please enter your name.");
            string name = Console.ReadLine();

            Console.WriteLine("How much sleep did you get last night?");
            int hoursOfSleep = int.Parse(Console.ReadLine());

            Console.WriteLine("Hey, World. Sup " + name);

            if (hoursOfSleep < 8)
            {
                Console.WriteLine("You must be tired!");
            }
            else
            {
                Console.WriteLine("I bet you feel rested!");
            }

            
        }
    }
}
