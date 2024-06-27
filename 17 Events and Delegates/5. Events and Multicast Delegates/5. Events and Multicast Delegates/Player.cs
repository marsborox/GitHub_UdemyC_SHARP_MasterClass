using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _5._Events_and_Multicast_Delegates
{
    //Player name
    
    public class Player
    {
        public string PlayerName { get; set; }

        public Player(string name)
        {
            this.PlayerName = name;
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }

        //at the start of game spawn player
        private void StartGame()
        {
            Console.WriteLine($"Spawning Player with ID : {PlayerName}");
        }

        private void GameOver()
        {
            Console.WriteLine($"Removing Player with ID {PlayerName}");
        }
    }
}
