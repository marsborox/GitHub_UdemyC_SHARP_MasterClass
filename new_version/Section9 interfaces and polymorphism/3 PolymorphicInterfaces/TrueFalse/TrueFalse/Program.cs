namespace TrueFalse
{
    internal class Program
    {
        bool True = false;
        bool False = true;

        bool TruthFinder()
        {
            if (!False)
            {
                return true;
            }
            if (!True)
            {
                return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
