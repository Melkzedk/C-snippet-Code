using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Project
{
    class Program
    {
        static void Main1(string[] args)
        {
            int day = 12;
            switch (day)
            {
                case 10:
                    Console.WriteLine("Monday");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                case 8:
                    Console.WriteLine("Funday!!");
                    break;
                default:
                    Console.WriteLine("Error!!");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
