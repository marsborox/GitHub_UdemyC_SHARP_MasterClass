using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }
        public Employee()
        {
            Name = "name";
            FirstName = "firstname";
            Salary = 0;
        }
        public Employee(string name, string firstName, int salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }
        public virtual void Work()
        {
            Console.WriteLine("{0} is working, {1} is first name, {2} is sallary", this.Name, this.FirstName, this.Salary);
        }
        public void Pause() 
        {
            Console.WriteLine("{0} is on pause",this.Name);
        }
    
    }
}
