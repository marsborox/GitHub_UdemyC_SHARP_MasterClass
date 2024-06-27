namespace _7_Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("price is {0}, pis is {1}, at is {2}", 32, 3.14,'@');

            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", 1,2,3,4,5,6,7,8,9,1+2+3+4+5+6+7+8+9);

            ParamsMethod("this", "is", "stupidly", "long", "array", "of", "strings");

            int price = 50;
            float pi = 3.14f;
            char at = 'A';
            string book = "whatever";
            ParamsMethod2(price, pi, at,book);
        }
        public static void ParamsMethod(params string[] sentence)
        {
        for (int i = 0; i < sentence.Length; i++)
            {                           //to icko je vlastne poradie v array - index
                Console.Write(sentence[i] + " ");
                Console.WriteLine();
            }
        }


        public static void ParamsMethod2(params object[] stuff)
        {
            foreach (object obj in stuff)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
