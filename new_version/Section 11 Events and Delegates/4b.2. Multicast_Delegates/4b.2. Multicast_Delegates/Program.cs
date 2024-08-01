namespace _4b._2._Multicast_Delegates
{
    public delegate void LogHandler(string message);
    //So if you want to use the log handler, we need to make sure that the method that we assign to it follows
    //the same declaration.
    public class Logger
    {//here we define methods
        public void LogToConsole(string message)
        {
            Console.WriteLine("Console Log: " + message);
        }
        public void LogToFile(string message)
        {
            Console.WriteLine("File log: " + message);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            //here we take LogToConsole method and assign it to variable
            LogHandler logHandler = logger.LogToConsole;

            //this wil lcreate multicast delegate - add method to it
            logHandler += logger.LogToFile;
            //this will now invoke all methods in multicast delegate
            logHandler("Log this info!");
            //we can remove as well
            logHandler -= logger.LogToFile;

            // ***WARNING***
            // be sure we are not invoking null bcs ... problems
        }
    }
}
