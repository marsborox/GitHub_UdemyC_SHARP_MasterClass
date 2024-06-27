namespace Conversion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myStrang = "10";
            string myStrang2 = "20";
            int num1 = Int32.Parse(myStrang);
            int num2 = Int32.Parse(myStrang2);
            int result = num1 + num2;
            Console.WriteLine(result);
        }
    }
}
