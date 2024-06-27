namespace _8_Own_interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chair officeChair = new Chair("Yellow","Wood");
            Chair gamingChair = new Chair("Red","Steel");
            Car damagedCar = new Car(150f,"Rusty");

            Console.WriteLine("{0}",officeChair.Color);
            
            damagedCar.DestroyablesNearby.Add(officeChair);
            damagedCar.DestroyablesNearby.Add(gamingChair);

            damagedCar.Destroy();
        }
    }
}
