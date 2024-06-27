namespace First_class
{






    internal class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car(); //i want tu have object called audi that is of data type car new vytvori new instance of class, and stores in reference of audi
            audi.Drive();
            Car bmw = new Car();

            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                audi.Stop();
            }
            else 
            {
                Console.WriteLine("Car drives forever (right audi drives forever)");
            }
        }

    }
}
