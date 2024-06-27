using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._Events_and_Multicast_Delegates
{
    internal class RenderingEngine
    {
        public RenderingEngine() 
        {
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }
        private void StartGame()
        {
            //at the start of game we want to render stuff
            Console.WriteLine("Rendering Engine Started");
            Console.WriteLine("Drawing Visuals ......");
        }

        //when game is over we want to stop rendering engine
        private void GameOver()
        {
            Console.WriteLine("Rendering Engine Stopped");
        }
    }
}
