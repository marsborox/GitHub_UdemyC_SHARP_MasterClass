using System.Diagnostics.Metrics;

namespace break_continue_practice
{
    internal class Program
    {            //your loop should skip all divisible by 3 values and stops running when i = 10. not write 10
        static void Main(string[] args)
        {
            int i = -10;

            while (true)
            {
                
                if (i % 3 == 0)
                {
                    i++; continue;
                }
                if (i == 10)
                {
                    break;
                }
                // TODO
                if (i == 11)
                {
                    Console.WriteLine(" FINAL BREAK REACHED! This should not happen!");
                    break;
                }
                Console.WriteLine(i++);
            }
        }
    }
    
}
