using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_class
{
    internal class Car // tu mam akoze nazov classu a v { } je constructor simmilar as method
    {
        public Car()
        {
            Console.WriteLine("Car was created");
        }
        public void Drive() {
            Console.WriteLine("Car is driving"); // nov every car will have method drive
        }
        public void Stop() { 
            Console.WriteLine("Damn thing is broken again");
        }
    }
}
