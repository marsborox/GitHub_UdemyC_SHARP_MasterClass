using System.Security.Cryptography.X509Certificates;

namespace IFS_Login_Challenge
{
    internal class Program
    {
        static string username;
        static string password;


        static void Main(string[] args)
        {
            Register();
            Login();

        }
            static void Register()
            {
                Console.WriteLine("register yourself, type you name");
                username = Console.ReadLine();
                Console.WriteLine("your username is " + username);
                Console.WriteLine("write your password");
                password = Console.ReadLine();
                Console.WriteLine("your password is " + password);

            }
            public static void Login()
            {
                Console.WriteLine("enter your login: ");

            if (username == Console.ReadLine())
            {
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("successfull login");
                }
                else { Console.WriteLine("invalid password"); }
            }
            else { Console.WriteLine("invalid username"); }
            }
        
    }
}
