using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Vehicle  // base class (parent) 
{
    public string brand = "Ford";  // Vehicle field
    public void honk()             // Vehicle method w
    {
        Console.WriteLine("Tuut, tuut!");
    }
}
class Car : Vehicle  // derived class (child)
{
    public string modelName = "Mustang";  // Car field
}
namespace C_Sharp_Project
{
    class Inheritence
    {
        static void Main(string [] args) { 
        // Create a myCar object
        Car myCar = new Car();

        // Call the honk() method (From the Vehicle class) on the myCar object
        myCar.honk();

    // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
    Console.WriteLine(myCar.brand + " " + myCar.modelName);
            Console.ReadLine();

            }
    }
}
