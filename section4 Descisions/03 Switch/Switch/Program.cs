namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your age");
            int age = int.Parse(Console.ReadLine());

            switch (age)
            {
                case <18 :
                    Console.WriteLine("Tooyoung");
                    break;
                case >25: Console.WriteLine("Too Old");
                    break;
                default :
                    Console.WriteLine("justgo");
                    break;




            }
        }
    }
}
