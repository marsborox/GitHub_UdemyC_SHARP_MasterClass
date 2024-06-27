namespace Exercise_Ternary
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
            Measurement();
            ParseCheck();
        }
        static void Measurement()
        {
            Console.WriteLine("what is the temperature");
            measurement = Console.ReadLine();
        }

        public static void ParseCheck()
        {
            bool success = int.TryParse(measurement, out temperature);
            if (success)
            {
                Console.WriteLine("temperature is " + temperature); IsItCold(); TemperatureOutput();
            }
            else { Console.WriteLine(measurement + " is not a number"); }
            
        }
        public static void IsItCold()
        {                        // take temperature if value above 100 output gass if not check temperature, if its lower than 0 solid if above liquid
            howcold = temperature <= 15 ? "it is too cold here" : temperature <= 28 ? "it is ok" : "it is hot in here";
            howcold = temperature >= 16 && temperature <= 28 ? "it is ok" : temperature > 28 ? "it is hot in here": "it is cold";
            // these 2 lines do same thing
        }
        public static void TemperatureOutput()
        {
            Console.WriteLine(howcold);
        }

    }
}
