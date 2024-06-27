namespace _1._Delegates_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> names = new List<string>() { "Aiden", "Sif","Walter","Anatoli"};

            Console.WriteLine("---before---");
            foreach (string name in names) 
            {
                Console.WriteLine(name);
            }
            names.RemoveAll(Filter);

            Console.WriteLine("---after---");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            
        }
        static bool Filter(string s) 
        {
            //return wheter the string s contains letter "i"
            //the Vontains method will return bool we will return as well
            return s.Contains("i");
        }
    }
}
