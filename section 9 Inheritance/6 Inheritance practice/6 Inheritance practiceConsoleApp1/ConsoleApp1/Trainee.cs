using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Trainee : Employee
    {
        protected string WorkingHours { get; set; }
        protected string SchoolHours { get; set; }
        public Trainee(){}

        public Trainee(string name, string firstName, int salary, string workingHours, string schoolHours):base(name,firstName,salary)
        {
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }
        public override void Work() 
        {
            Console.WriteLine("{0} is working, {1} is first name, {2} is sallary, {3} are working hours, {4} is in school", 
                this.Name, this.FirstName, this.Salary,this.WorkingHours, this.SchoolHours);
        }
        public void Learn() 
        {
        
        }
    }
}
