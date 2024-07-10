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
            //add to dictionary
            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();
            foreach (Employee emp in employees)
            {
                employeesDirectory.Add(emp.Role, emp); // co ma pridat do dictionaire
            }
            string key = "CEO";
            if (employeesDirectory.ContainsKey(key))
            {
                Employee empl = employeesDirectory[key]; //podla coho ma spravit output
                Console.WriteLine("Employee name: {0}, Role: {1}, Salary: {2}", empl.Name, empl.Role, empl.Salary);
            }
            else { Console.WriteLine("Does not exist"); }

            //this will return dictionary entry / a object
            string input = "CEO";
            Employee result = null;
            if (employeesDirectory.TryGetValue(input, out result))
            {
                Console.WriteLine("NAME: {0}, ROLE: {1}, SALARY: {2}", result.Name, result.Role, result.Salary);
            }
            else 
            {
                Console.WriteLine("Does not exist");
            }

            for (int i = 0; i < employeesDirectory.Count; i++)
            {
                //using ElementAt(i) to return the key-value pair stored at index i
                KeyValuePair < string, Employee > KeyValuePair = employeesDirectory.ElementAt(i);
                //print the key
                Console.WriteLine("Key: {0}", KeyValuePair.Key);
                //storing the vlaue in an employee object
                Employee employeeValue = KeyValuePair.Value;
                //printing the properties of the employee object
                Console.WriteLine("NAME: {0}, ROLE: {1}, SALARY: {2}", employeeValue.Name, employeeValue.Role, employeeValue.Salary);
            }
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
