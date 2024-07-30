namespace _4b_Intro_to_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, };
            string[] stringAwway = { "one", "two", "Three" };

            PrintGenericArray(intArray);
            PrintGenericArray(stringAwway);
        }
        //we have 2 methods that each prints separate data type
        //its problem when we dont know which will come in, it could be 20 methods after all
        //objects colelctions anything can come through
        public static void PrintIntArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
        public static void PrintStringArray(string[] array)
        {
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }
        }
        //this will print whatever it gets
        public static void PrintGenericArray<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
