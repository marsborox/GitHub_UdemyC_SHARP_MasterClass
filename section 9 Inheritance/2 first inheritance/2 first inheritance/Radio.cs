using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_first_inheritance
{
    internal class Radio : ElectricalDevice
    {

        //:base(isOn, brand)
        public Radio(bool isOn, string brand):base(isOn, brand)
        {
            //dont need
           /*
            IsOn = isOn;
            Brand = brand;*/
        }

        //switch on
        /*
        public void SwitchOn()
        {
            IsOn = true;
        }
        //switch off
        public void SwitchOff()
        {
            IsOn = false;
        }
        */
        public void ListenRadio()
        {   //check if radio is on
            if (IsOn)
            {
                //lsiten to the radio
                Console.WriteLine("Listening to the Radio");
            }
            else
            {
                //print error
                Console.WriteLine("radio is off turn it on first");
            }
        }
    }
}
