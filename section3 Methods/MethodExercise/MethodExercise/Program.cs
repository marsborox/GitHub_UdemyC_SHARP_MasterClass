namespace MethodExercise
{
    internal class Program
    {
        

            static string LowUpper(string s)
            {
                return s.ToLower() + s.ToUpper();
            }

            static void Count(string s)
            {
                int result = s.Length;
                Console.WriteLine("Ammount of characters is " + result);
            }
            // Place for your methods

            static void Main(string[] args)
            {
                // We encourage you to test your code with different strings,
                // but don't forget to put the default string back at the end of your testing.
                string s = "HeY ThErE !";

                /// Change nothing down here 
                s = LowUpper(s);
                Console.WriteLine(s);
                Count(s);
            }
         }
}
