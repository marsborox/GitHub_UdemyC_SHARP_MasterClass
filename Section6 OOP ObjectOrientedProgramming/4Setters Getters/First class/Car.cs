using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_class
{
    internal class Car // tu mam akoze nazov classu a v { } je constructor simmilar as method
    {
        //member variable
        private string _name; // private field typically used to store data, we will give the car name when its created
        private int _hp;
        private string _color;
        public int GetHp()
        {
            return _hp;
        }
        public void SetName(string name)
        {
            if (name == "")
            {
                _name = "Default";
            }
            else
            {
                _name = name;
            }
        }
        public string GetName() 
        {
            return _name;
        }
        // Default constructor
        public Car()
        {
            _name = "Car";
            _hp = 0;
            _color = "red";
            //non default constructor
        }
        //partial specification
        public Car(string name, int hp = 0)
        {
            _name = name; //moment it is created we will give it name
            Console.WriteLine(name + " was created");
            this._name = name;//
            _hp = hp;
            _color = "red";
        }
        //full specification
        public Car(string name, int hp = 0, string color = "black")
        {
            _name = name; //moment it is created we will give it name
            Console.WriteLine(name + " was created");
            this._name = name;//
            _hp = hp;
            _color = color;
        }
        //class member methods
        public void Drive() {
            Console.WriteLine(_name + " is driving"); // nov every car will have method drive
        }
        public void Stop() {
            Console.WriteLine(_name + " is broken again");
        }
        public void Details()
        {
            Console.WriteLine(_color+" " + _name + " has " + _hp + " horsepower");
        }
    }
}
