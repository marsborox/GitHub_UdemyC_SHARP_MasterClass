using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Interfaces
{
    internal class Ticket : IEquatable<Ticket>
    {
        //property to store the duration of the ticket in hours
        public int DurationInHours { get; set; }
        // simple constructor
        public Ticket(int durationInHours)
        {
            DurationInHours = durationInHours;
        }   
        public bool Equals(Ticket other) 
           // want to check if the ticket i am passing 
        {//comper "this"ticket duration of hrs to "other" ticket duration hours

            return DurationInHours == other.DurationInHours;
        }
    }
}
