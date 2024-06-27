using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._Events_and_Multicast_Delegates
{
    public class AudioSystem
    {
        public AudioSystem()
        {
            //subscribe to the Onstart and OnGameOver events
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }
        //at the start of the game enable audio play music
        private void StartGame()
        {
            Console.WriteLine("Audio System Started");
            Console.WriteLine("Playing Audio...");
        }
        //when game is over stop the audio
        private void GameOver()
        {
            Console.WriteLine("Audio System Stopped");
        }
    }
}
