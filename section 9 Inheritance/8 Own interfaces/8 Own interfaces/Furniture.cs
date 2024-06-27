using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Own_interfaces
{
    class Furniture
    {
        //color
        public string Color { get; set; }
        //material
        public string Material { get; set; }
        //default constructor
        public Furniture() 
        {
            Color = "White";
            Material = "Wood";
        }
        //simple constructor
        public Furniture(string color, string material)
        {
            Color = color;
            Material = material;
        }
    }
}
