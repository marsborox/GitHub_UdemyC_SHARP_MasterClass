using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace members
{
    internal class Members
    {
        // member private field
        private string memberName;
        private string jobTitle;
        private int salary = 20000;
        // member public field
        public int age;
        //member property start with Capital letter
        public string JobTitle 
        {
            get 
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            } 
        }
        //public member Method - can be called from other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else 
            {
                Console.WriteLine("Hi my name is {0} and i am {1}, im {2 years old.}",memberName,jobTitle,age);
            }
        }
        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0} ", salary);
        }
        //member constructor
        public Members()
        {
            age = 30;
            memberName = "Jodi";
            salary = 60000;
            jobTitle = "Developer";
            Console.WriteLine("Object created");
        }
        // finaliser destructor can beo nly open, can not be called can not inheritet or overloaded
        //or be called, only this calss, only if objec runs out of scope it is called
        ~Members()
        {
            //cleanup statements
            Console.WriteLine("Deconstruction of members object");
            Debug.Write("Destruction of Members object");
        }
    }
}
