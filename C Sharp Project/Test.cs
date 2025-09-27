using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Project
{
    class Test
    {
        static void Main4(string[] args)
        {
            String name = "John Doe";
            int age = 20;
            int marks = 60;
            int mark1 = 60;
            Console.WriteLine(name + " is "   +age);

            if (marks > 40) {
                Console.WriteLine("Passesd!!");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Failed!!");
                Console.ReadLine();
            }
        }
    }
}
