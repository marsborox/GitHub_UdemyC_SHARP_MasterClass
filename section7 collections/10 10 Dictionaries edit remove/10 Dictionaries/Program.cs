namespace _10_Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {//number is key, string is the value
            Employee[] employees =
            {
            new Employee("CEO","Gwyn",95,200),
            new Employee("Manager", "Joe", 35, 25),
            new Employee("HR","Lora",32,21),
            new Employee("Secretary","Petra",28,18),
            new Employee("Lead Developer","Artorias",55,35),
            new Employee("Intern","Ernest",22,8),
            };
            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                {1,"one"},
                {2,"two"},
                {3,"three"}
            };
            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();
            foreach (Employee emp in employees)
            {
                employeesDirectory.Add(emp.Role, emp); // co ma pridat do dictionaire
            }
            //update
            string keyToUpdate = "HR";
            if (employeesDirectory.ContainsKey(keyToUpdate)) // check if key exists
            {
                employeesDirectory[keyToUpdate] = new Employee("HR", "Eleka", 26, 18);//this will update it
                Console.WriteLine("Employee with Role/Key {0} was updated", keyToUpdate);

            }
            else { Console.WriteLine("{0}Does not exist",keyToUpdate); }
            //remove
            string keyToRemove = "Intern";
            if (employeesDirectory.Remove(keyToRemove))
            {
                Console.WriteLine("{0} has been removed", keyToRemove);
            }
            else { Console.WriteLine("{0}Does not exist", keyToRemove); }

        }
    }
    
    public class Employee
    {
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }
        public float Salary
        {
            get
            {
                return Rate * 8 * 4 * 12;
            }
        }
        public Employee(string role, string name, int age,float rate) 
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;
        }
    }
}

namespace Coding.Exercise
{
    public class Speller
    {

        public static string Convert(int i)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>()
            {
                {0, "zero"},
                {1, "one"},
                {2, "two"},
                {3, "three"},
                {4, "four"},
                {5, "five"}
            };

            if (dic.ContainsKey(i))
                return dic[i];
            else
                return "nope";

        }
    }
}