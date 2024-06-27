using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_first_inheritance
{
    internal class ElectricalDevice
    {
        public bool IsOn { get; set; }

        public string Brand { get; set; }

        public ElectricalDevice(bool isOn, string brand)
        {
            IsOn = isOn;
            Brand = brand;
        }

        //switch on
        public void SwitchOn()
        {
            IsOn = true;
        }
        //switch off
        public void SwitchOff()
        {
            IsOn = false;
        }
    }
}
