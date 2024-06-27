namespace Method1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSpecific("I am argument and am called from a method");

        }

        public static void WriteSomething()
        { 
        Console.WriteLine("write something");
        Console.Read();
        }

        public static void WriteSpecific(string myText)
        { 
        Console.WriteLine(myText);
            Console.Read();
        }


        
    }
}

