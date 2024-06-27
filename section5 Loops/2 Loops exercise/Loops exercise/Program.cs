using System.Diagnostics.Metrics;

namespace Loops_exercise
{
    internal class Program
    {
        public class Exercise
        {
            public static void ForLoop()
            {
                for (int counter1 = -3; counter1 != 4; counter1++)
                {
                    Console.WriteLine(counter1);
                }
                // TODO
            }


            public static void WhileLoop()
            {
                int counter2 = 4;
                while (counter2 != -3)
                {
                    counter2--;
                    Console.WriteLine(counter2);
                }// TODO
            }

            public static void Main()
            {
                WhileLoop();
                ForLoop();

            }
        }
    }
}
