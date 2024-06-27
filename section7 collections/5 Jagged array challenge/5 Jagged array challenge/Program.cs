namespace _5_Jagged_array_challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {       // jagged arrays 3 friend arrays in which 2 family mmebers stored
                // introdus them to each other via console
            string[][] friendsAndFamily = new string[][]
                {
                    new string []{"Michael", "Sandy"},
                    new string []{ "Jozef", "Suzy" },
                    new string []{"Villiam", "Vlad" }
                };
            Console.WriteLine("helli {0},this is {1}", friendsAndFamily[0][0], friendsAndFamily[1][1]);
            Console.WriteLine("helli {0},this is {1}", friendsAndFamily[1][0], friendsAndFamily[2][1]);
            Console.WriteLine("helli {0},this is {1}", friendsAndFamily[2][0], friendsAndFamily[0][1]);
        }
        string[] joesFamily = new string[] { };
    }
}
