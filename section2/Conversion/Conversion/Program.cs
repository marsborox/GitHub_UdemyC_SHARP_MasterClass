using System.Diagnostics.CodeAnalysis;

namespace Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberfunky = 99;
            long longy;
            longy = (int)numberfunky;
            Console.WriteLine(longy);

            short shorty = 25;
            int shortyint = Convert.ToInt32(shorty);
            Console.WriteLine(shortyint);

            double myDouble = 13.37;
            string myString = myDouble.ToString(); // seems some types have definition of "To<type>


            try
            {
                Console.WriteLine("type number here");
                string stringy = Console.ReadLine();
                int stringFromInt = Convert.ToInt32(stringy);
                Console.WriteLine(stringFromInt + " is a number");
            }
            catch (Exception)
            {
                Console.WriteLine("Thats not a number id10t");



                string myStrang = "10";
                string myStrang2 = "20";
                int num1 = Int32.Parse(myStrang);
                int num2 = Int32.Parse(myStrang2);
                int result = num1 + num2;
                Console.WriteLine(result);


                static void exercise(string[] args)
                {
                    string stringForFloat = "0.85"; // datatype should be float
                    float Floaty = float.Parse(stringForFloat);
                    string stringForInt = "12345"; // datatype should be int
                    int intey = int.Parse(stringForInt);
                }
            }
            string error = "not work error LOL";
            decimal bignumber = 9999;


            int sbignumber = Convert.ToInt32(bignumber);
            try
            {
                string bignumber2 = "1234";
                int bbignumber = Convert.ToByte(bignumber2);
            }
            catch (Exception)
            {
                Console.WriteLine(error);
            }
            Console.WriteLine("Enter a number");
            string userInput = Console.ReadLine();
            try
            {

            }
            catch (Exception)
            {

                throw;
            }


            int parsedValue;
            double sum = 0;
            double ammount = 0;

            while (true)
            {
                Console.WriteLine("enter mark");
                string mark = Console.ReadLine();
                bool success = int.TryParse(mark, out parsedValue);
                if (success && 0 < parsedValue && parsedValue < 20)
                {
                    sum = sum + parsedValue;
                    ammount++;
                }
                else if (parsedValue == -1)
                {
                    double average = sum / ammount;
                    Console.WriteLine("average is" + average);
                    break;
                }
                else
                {
                    Console.WriteLine("wrong input");
                }
            }
        }
    }
}
