using System.Diagnostics.Metrics;

namespace Test_TryParse
{
    internal class Program
    {
        static int temperature;
        static string measurement;
        static string stateofmatter;
        static string stateofmatter2;
        static string howcold;
        static void Main(string[] args)
        {
            string numberAsString = "128";
            int parsedValue;


            string temperature = Console.ReadLine();
            string measurement = Console.ReadLine();

            int number;
            int numTemp;


            if (int.TryParse(temperature, out number))
            {
                numTemp = number;
            }
            else
            {
                numTemp = 0;
                Console.WriteLine("not number entered");
            }

        }
        static void ParseCheck()
        {
            bool success = int.TryParse(measurement, out temperature);
            if (success)
            {
                Console.WriteLine("temperature is " + temperature);
            }
            else { Console.WriteLine(measurement + " is not a number"); }
        }
    }
}
