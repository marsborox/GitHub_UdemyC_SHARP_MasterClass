namespace _5._Events_and_Multicast_Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create audio system
            AudioSystem audioSystem = new AudioSystem();
            //create rendering engine
            RenderingEngine renderingEngine = new RenderingEngine();
            //create two players and give them Id's
            Player player1 = new Player("SteelCow");
            Player player2 = new Player("DoggoSilva");

            GameEventManager.TriggerGameStart();

            Console.WriteLine("Game is Running ... press any key to end the game");

            Console.Read();
            GameEventManager.TriggerGameOver();

        }
    }
}
