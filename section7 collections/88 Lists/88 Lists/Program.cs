namespace _88_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: write your solution here
            static List<int> Solution()
            {
                // TODO: write your solution here
                //create a new list 
                List<int> myList = new List<int>();
                //go thorugh every number beyweem 100 and 170
                for (int i = 100; i <= 170; i++)
                {
                    //check if its an even number
                    if (i % 2 == 0)
                    {
                        //add it to the list
                        myList.Add(i);
                    }
                }
                //return the list
                return myList;
            }
            //do <  > ide typ  objectu ktory tam storujem
            List<Player> players = new List<Player>();
            Player player1 = new Player("chad");
            Player player2 = new Player("Steve");
            Player player3 = new Player("Karen");

            //we can adde them directly without naming them

            players.Add(player1);
            players.Add(player2);
            players.Add(player3);

            players.Add(new Player("Joseph"));


            foreach (Player player in players)
            {
                Console.WriteLine("{0} is added to game", player.username);
            }
        }
    }
    class Player
    {
        public String username;
        public Player(String username)
        {
            this.username = username;
        }

        public override string ToString()
        {
            return username;
        }
    }
}
