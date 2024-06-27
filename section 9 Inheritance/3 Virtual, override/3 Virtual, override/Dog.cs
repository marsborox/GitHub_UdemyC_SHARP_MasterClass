using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Virtual__override
{
    internal class Dog : Animal
    {
        public bool IsHappy { get; set; }
        //simple constructor where we pass the name and age to our base constructor

        public Dog (string name, int age):base(name, age) 
        {   //all dogs are happy
            IsHungry = true;
        }
        public override void Eat()
        {//call from parent class
            base.Eat();
        }
        public override void MakeSound()
        {
            Console.WriteLine("WOOOOF");
        }
        public override void Play()
        {
            if (IsHappy)
            { base.Play();} 
        }

    }
}
