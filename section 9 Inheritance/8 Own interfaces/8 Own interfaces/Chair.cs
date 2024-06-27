using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _8_Own_interfaces
{
    internal class Chair:Furniture, IDestroyable
    {
        public string DestructionSound {  get; set; }

        public Chair (string color,string material):base (color,material) 
        {
            DestructionSound = "Chair burning";
        }
        public void Destroy()
        {
            Console.WriteLine("{0} chair was destroyed",Color);
            Console.WriteLine("playing sound {0}",DestructionSound);
        }
    }
}
