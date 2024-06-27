using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Boss:Employee
    {
        protected string CompanyCar {  get; set; }
        public Boss() { }
        public Boss(string name, string firstName, int salary, string companyCar):base(name,firstName, salary)
        {
            this.Name = name;
        }
        public void Lead()
        {
            Console.WriteLine("{0} is leading", this.Name);

        }
    }
}
