using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Own_interfaces
{
    internal class Car:Vehicle,IDestroyable
    {
        public string DestructionSound { get; set; }
        //we create new property to store destroyable objects
        //when car gets destroyed it should destory nearby objects
        //type IDestroyable it can store any object
        //that implements this interface and can only acess
        //the properties and methods in this interface

        public List<IDestroyable> DestroyablesNearby;

        public Car(float speed, string color):base (speed, color)
        {
            //initialize the interfaces property with vlaue in the constructor
            DestructionSound = "CarExplosionSound.mp3";
            DestroyablesNearby = new List<IDestroyable>();
        }
        //implementing the interfaces method

        public void Destroy()
        {
            Console.WriteLine("Car has blown up {0}",DestructionSound);
            //go through each destroyable object nearby and call its destroy method

            foreach (IDestroyable destroyable in DestroyablesNearby) 
            {
                destroyable.Destroy();
            }
        }
    }
}
