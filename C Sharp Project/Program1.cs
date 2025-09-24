using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Project
{
    class Program1
    {
        static void Main(string[] args)
        {
            try
            {
                var number = "12345";
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);
                Console.ReadLine();
            }
            catch (Exception)
           {
                Console.WriteLine("The number couldn't be converted to byte");
                Console.ReadLine();
            }
        }
    }
}
