using System.Diagnostics;

namespace String_manipulaiton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int age = 31;
            string name = "Alfonso";
            string id = "Mu ID is 255";

            // string concatenation
            Console.WriteLine("Hullo my name is" + name + "i am " + age + "years old");

            // string formatting - uses index

            Console.WriteLine("Hello my name is {0} i am {1} years old {2}", name, age, id); // tieto indexy

            // string interpolaiton

            Console.WriteLine($"Hello my name is {name}, I am {age} years old {id}");

            // Verbatim strings
            //start with @ and tell compiler to take string literally - it i add some enters into "" it iwll be there
            //and ignore spaces and escape characters like \n


            Console.WriteLine(@"dfadsfjkdsafhskdajfhsadk
fjsadlkfjsdkla




fjsldkafjsadklfjsadlkfjslad");



            string s1 = "this is a string \"string\" with backslash \n \\ and a colon: ";
            Console.WriteLine(s1);


            Console.WriteLine("Please enter your name and press enter");



            string s3;
            s3 = Console.ReadLine();

            

            string uppercaseString = String.Format("Uppercase: {0}", s3.ToUpper());
            string lowercaseString = String.Format("Lowercase {0}", s3.ToLower());
            string trimmedString = String.Format("Trimmed {0}", s3.Trim());
            string substring = String.Format("Substring Value {0}", s3.Substring(0, 2));

            Console.WriteLine(uppercaseString);
            Console.WriteLine(lowercaseString);
            Console.WriteLine(trimmedString);
            Console.WriteLine(substring);


            Console.WriteLine("Enter word");
            string input = Console.ReadLine();
            Console.WriteLine("enter char");
            char searchInput = Console.ReadLine()[0];
            int searchIndex = input.IndexOf(searchInput); // input which position is the character we are looking for
            Console.WriteLine("Index of character {0}  we search for is {1}", searchInput, searchIndex);


            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();

            string fullName = string.Concat(firstName," ", lastName);
            Console.WriteLine("Your full name is {0}", fullName);

            Console.ReadKey();
            


        }
    }
}
