using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._Events_and_Multicast_Delegates
{
    internal class GameEventManager
    {
        public delegate void GameEvent();

        public static GameEvent OnGameStart, OnGameOver;

        public static void TriggerGameStart()
        {
            //check if the OnGameStart event is not empty meaning that other methods already subscribed
            if (OnGameStart != null)
            {
                //print simple msg
                Console.WriteLine("The Game has started....");
                //call the OnGameStart that will trigger all methods subscribed in this event
                //it will execute all methods with this "state"

                OnGameStart();
            }    
        }
        public static void TriggerGameOver() 
        {
            if(OnGameOver != null) 
            {
                Console.WriteLine("Game has ended.....");

                OnGameOver();
            }
        }
    }
}
