using System.Transactions;

namespace Input_catch_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Calculate());
            Console.Read();

            Console.WriteLine("write role");
            string input = Console.ReadLine();
            Employee result = null;
            if (employeesDirectory.TryGetValue(inpiut, out result))
            {
                Console.WriteLine("NAME: {0}, ROLE: {1}. SUMMARY: {2}",result.Name, result.Role, result.Salary);
            }
        }
        public static string Calculate()
        {
            Console.WriteLine("write number 1");
            string input1 = Console.ReadLine();
            Console.WriteLine("you wrote " + input1);
            Console.WriteLine("write number 2");
            string input2 = Console.ReadLine();
            Console.WriteLine("you wrote " + input2);

            int num1 = int.Parse(input1);
            int num2 = int.Parse(input2);
            int result = num1 + num2;
            string output = result.ToString();

            return output;
        }

        public static string Calculate2()
        { 
        Console.WriteLine("enter a number ");
            string userInput= Console.ReadLine();
            try
            {

            }
            catch (Exception)
            {

               
            }
            
        }
        


            
        
    }
}
