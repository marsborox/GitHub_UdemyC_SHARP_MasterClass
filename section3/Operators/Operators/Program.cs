using System;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
            int num3;
            // unarz operator

            num3 = -num1;
            Console.WriteLine("num3 is {0}", num3);

            bool isSunny = true;
            Console.WriteLine("is it sunny{0}", isSunny);

            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num++); //number is changed after we use it postincrement
            Console.WriteLine("num is {0}", ++num); //nuber is changed before we use it preincrement
            Console.WriteLine();
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num--); //postdicrement
            Console.WriteLine("num is {0}", --num); //predecrement

            int result;
            result = num1 + num2;
            Console.WriteLine("result of num1 + num2 is {0}" ,result);
            result = num1 - num2;
            Console.WriteLine("result of num1 - num2 is {0}", result);
            result = num1 / num2;
            Console.WriteLine("result of num1 / num2 is {0}", result);
            result = num1 * num2;
            Console.WriteLine("result of num1 * num2 is {0}", result);
            result = num1 % num2;
            Console.WriteLine("result of num1 % num2 is {0}", result); // modular operator - vzdeli vrati zvysok

            bool isLower;
            
            isLower = num1 > num2;
            Console.WriteLine("result of num 1 > Num 2 is {0}", isLower);
            isLower = num1 < num2;
            Console.WriteLine("result of num 1 < Num 2 is {0}", isLower);
        }
    }
}
