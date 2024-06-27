namespace First_class
{






    internal class Program
    {
        static void Main(string[] args)
        {
            Car mycar = new Car();
            Console.WriteLine(mycar.Name); //this will get the name
            mycar.MaxSpeed = 250;
            Console.WriteLine("mycar max speed is " + mycar.MaxSpeed);
        }
    }
}
