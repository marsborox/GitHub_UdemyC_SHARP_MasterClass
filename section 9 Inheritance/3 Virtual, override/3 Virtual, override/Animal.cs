using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Virtual__override
{
    public class Animal
    {
        // class animal properties name, age, is hungry
        //constructor
        //methods make sound,eat, play
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            IsHungry = true;
        }
        public virtual void MakeSound()
        { 
            Console.WriteLine("{0}is making sound",Name); }
        public virtual void Eat()
        {
            Console.WriteLine("{0} has eaten",Name);
            IsHungry = false;
        }
        public virtual void Play()
        { Console.WriteLine("{0} is playing",Name); }
    }
}
