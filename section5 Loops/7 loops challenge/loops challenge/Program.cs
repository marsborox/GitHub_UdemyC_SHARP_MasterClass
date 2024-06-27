using System.ComponentModel.Design;
using System.Reflection;

namespace loops_challenge
{
    internal class Program
    {
        //enter values only between 0 and 20 (excluding) and when typing -1 output average
       
        static void Main(string[] args)
        {

            int parsedValue;
            double sum =0;
            double ammount = 0;
            

            while(true)
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
                    Console.WriteLine("average is " + average);
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
