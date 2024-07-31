namespace _4b._4._Intro_PubSub
{
    public delegate void Notify(string message);
    // the "Notify" is signature of methods that should handle the event
    public class EventPublisher
    {//The "On" prefix makes it immediately clear that the method
        //is associated with an event.
        //It signifies that the method is not just a regular method but
        //one that is called when a specific event occurs.
        public event Notify OnNotify;

        public void RaiseEvent(string message)
        {
            OnNotify?.Invoke(message);
            //we are going to invoke the event if there are subscribers
            //they may be none subscribers, thats why the "?"
        }
    }
    public class EventSubscriber
    {
        public void OnEventRaised(string message)
        {
            //when event is raised then we will 
            //do this - here is what we want to happen
            Console.WriteLine("Event received");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //then we prepare publisher and subscriber
            EventPublisher publisher = new EventPublisher();
            EventSubscriber subscriber = new EventSubscriber();

            // we set up publisher on notify and subscribe with our event raised method
            //that will be called when event is raised
            //this is how we subscribe to an event

            publisher.OnNotify += subscriber.OnEventRaised;
            //and when event is raised then we will call
            //what is inside of OnEventRaised method - its allways on EventRaised
            //probably but the content is what we will put there

            //once the raise event of publisher method is called 
            //then we are raising the event
            //and we are executing  whatever methods are listening to us

            publisher.RaiseEvent("test");
        }
    }
}
