namespace Methods_with_return
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(15,31));
            Console.Read ();

            Console.WriteLine(Add2(Add2(1, 2), Add2(3, 4)));
            Console.WriteLine(Multiply(2, 8));
            Console.WriteLine(Divide(10,5));


            string friend1 = "Jozef";
            string friend2 = "Jezis";
            string friend3 = "Takac";

            GreetFriend (friend1);
            GreetFriend (friend2);
            GreetFriend (friend3);

            Console.Read();
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Add2(int num3, int num4) 
        {
            return num3 + num4;
        }

        public static int Multiply(int num5, int num6)
        {
            return num5 * num6;
        }

        public static double Divide(int num7, int num8)
        { 
            return num7 / num8;
        }
        public static void GreetFriend(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}
