namespace While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string enteredText = "";
            while (enteredText.Equals("")) //checks first before it does everything
            {                               // if entered anything else it will shut
                Console.WriteLine("press enter to increase by one");
                enteredText = Console.ReadLine();
                counter++;
                Console.WriteLine("students on bus" + counter);
                
            }
            Console.WriteLine("{0} people are inside the bus. press enter to close program", counter);
            Console.Read();
        }
    }
}
