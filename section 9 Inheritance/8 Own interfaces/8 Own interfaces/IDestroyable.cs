using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace _8_Own_interfaces
{
    internal interface IDestroyable
    {

        //property to store destruction sound
        string DestructionSound { get; set; }
        //method to destroy object
        void Destroy();

    }
}
