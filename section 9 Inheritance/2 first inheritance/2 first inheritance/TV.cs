using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_first_inheritance
{
    internal class TV : ElectricalDevice
    {
    public TV(bool isOn, string brand) :base(isOn, brand)
        {
    
        }
        public void WatchTv()
        {   //check if radio is on
            if (IsOn)
            {
                //lsiten to the radio
                Console.WriteLine("Watching TV");
            }
            else
            {
                //print error
                Console.WriteLine("TV is off turn it on first");
            } 
        }
    }
}
