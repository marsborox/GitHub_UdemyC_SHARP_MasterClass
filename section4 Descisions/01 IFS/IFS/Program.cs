using System;
using System.ComponentModel.Design;

namespace IFS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the temperature");

            int temperature = int.Parse(Console.ReadLine());


            if (temperature < 10)
            {
                Console.WriteLine("take the coat");
            }
            else if (temperature == 10)
            {
                Console.WriteLine("its 10 degrees");
            }
            else
            {
                Console.WriteLine("its above 10 degrees");
            }
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";
            Console.WriteLine("enter your username");
            userName = Console.ReadLine();

            if (isRegistered)
            {
                Console.WriteLine("User is registrated");
                if (userName != "")
                { Console.WriteLine("your login is" + userName); }
                if (userName.Equals("Admin"))
                { Console.WriteLine("Hello Admin"); }

            }
            else
            { Console.WriteLine("User not registrated"); }
            Console.Read();

            if (isRegistered && userName != "" && userName.Equals("Admin")) // checkne 4i toto a toto a toto
            {
                Console.WriteLine("User is registrated");
                Console.WriteLine("your login is" + userName);
                Console.WriteLine("Hello Admin");
            }


            if (isAdmin || isRegistered)
            {
                Console.WriteLine("You are logged in"); 
            }
            
        }
    }
}


