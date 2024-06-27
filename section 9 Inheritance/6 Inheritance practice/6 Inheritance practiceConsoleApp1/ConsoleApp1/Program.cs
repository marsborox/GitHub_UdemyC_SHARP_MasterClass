namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Worker","Joe", 800);
            employee1.Work();

            Boss bigBoss1 = new Boss("Boss","BIG", 1500, "NSX");
            bigBoss1.Work();
            bigBoss1.Lead();
            Trainee jozku = new Trainee("Trainee", "Jozku",500,"14:00-17:00","08:00-12:00");
            jozku.Work();
        }
    }
}
