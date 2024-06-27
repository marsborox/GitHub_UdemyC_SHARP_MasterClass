using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        num = 13;
        int num2 = 22;
        int sum= num + num2;
        Console.WriteLine("num1: " + num);
        Console.WriteLine("num1:" + num + " + num2: " + num2 + " is " + sum);
        num2 = 100;

        int num4, num5, num6;

        string message = "asdf";
        string messageCaps = message.ToUpper();

        Console.WriteLine(messageCaps);

        string messageLower = messageCaps.ToLower();

        Console.WriteLine(messageLower);
        

        Console.WriteLine("****************************************");

        Console.WriteLine("WASSUP");

        Console.Write("YO");
        Console.ReadKey();

        Console.WriteLine("Enter a string nad press enter:");
        string readInput = Console.ReadLine();
        Console.WriteLine("You have written{0}:", readInput);

        Console.Write("Enter a string for ASCII value and press enter:");
        int asciiValue = Console.Read();
        Console.WriteLine("ASCII value is {0}:", asciiValue);
        Console.ReadKey();

        double d1 = 3.1415;
        double d2 = 5.1;
        double dDiv =d1 / d2;
        Console.WriteLine("d1/d2 is" + dDiv);
    }
}