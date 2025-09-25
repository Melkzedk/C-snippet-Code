using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Project
{
    class Test
    {
        static void Main(string[] args)
        {
            String name = "John Doe";
            int age = 20;
            int marks = 60;
            Console.WriteLine(name + age);
            Console.ReadLine();

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
