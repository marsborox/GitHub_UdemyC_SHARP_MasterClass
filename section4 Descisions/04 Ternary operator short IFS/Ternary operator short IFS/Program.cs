using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace Ternary_operator_short_IFS
{
    internal class Program
    {
        static int temperature;
        static string stateofmatter;
        static string stateofmatter2;

        static void Main(string[] args)
        {

            Measurement();
            FreezingCheck();
            FreezingCheckShort();
            TemperatureOutput();
        }
        static void Measurement()
        {
            Console.WriteLine("what is the temperature");
            temperature = int.Parse(Console.ReadLine());
                Console.WriteLine("it is " + temperature + " degrees");
        }
        public static void FreezingCheck() 
        {
            if (temperature < 0)
                stateofmatter = "solid";
            if (temperature > 100)
                stateofmatter = "gas";
            else
                stateofmatter = "liquid";       
        }
        public static void FreezingCheckShort() 
        {                        // take temperature if value above 100 output gass if not check temperature, if its lower than 0 solid if above liquid
            stateofmatter2 = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";
        }
            public static void TemperatureOutput() 
            {
            Console.WriteLine("watter is " + stateofmatter);
            Console.WriteLine("watter is " + stateofmatter2);
            }

        
    }
}
