namespace Break_and_continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 0; counter < 10; counter++)
            {
                
                if (counter %2 ==0)
                { 
                Console.WriteLine("now comes odd number");
                    continue; // will skip current entry 
            
                }
                Console.WriteLine(counter);
            }

            Console.Read();
        }
    }
}
