namespace First_class
{






    internal class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car("Audi A4",345, "blue"); //i want tu have object called audi that is of data type car new vytvori new instance of class, and stores in reference of audi
            audi.Drive();
            Car bmw = new Car("BMW M5",350);
            bmw.Drive();
            Console.WriteLine("press 1 to stop");
            audi.Details();
            bmw.Details();

            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                audi.Stop();
            }
            else 
            {
                Console.WriteLine("car drives forever ");
            }
        }

    }
}
