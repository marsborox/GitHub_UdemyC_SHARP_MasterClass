namespace _7_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ticket t1 = new Ticket(10);
            Ticket t2 = new Ticket(10);
            //we take t2 run Equals method against t1 as parameter
            Console.WriteLine(t2.Equals(t1));
        }
    }
}
