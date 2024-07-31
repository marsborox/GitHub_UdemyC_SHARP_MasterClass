namespace GetInvocationList
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
            // unsafely
            logHandler("Log this info!");

            //this invocation list will give us the items inside of the delegate
            foreach (LogHandler handler in logHandler.GetInvocationList())
            {
                try
                {
                    handler("Event occured with error handling");
                }
                catch (Exception ex) 
                {
                    Console.WriteLine("Exception caught: "+ex.Message);
                }
            }

            /*
            //we can remove as well
            logHandler -= logger.LogToFile;
            */

            if (IsMethodInDelegate(logHandler, logger.LogToFile))
            {//if method is in delegate then remove it from delegate
                logHandler -= logger.LogToFile;
                Console.WriteLine("LogToFile method removed");
            }
            else 
            {//so if we would never added LogToFile method to delegate 
                //we would get error
                Console.WriteLine("LogToFile Method not found!");
            }
            if (logHandler != null)
            {
                InvokeSafely(logHandler, "After removing LogToFile");
            }
        }
        static void InvokeSafely(LogHandler logHandler, string message)
        {
            LogHandler tempLogHandler = logHandler;
            if(tempLogHandler != null) 
            {
                tempLogHandler(message);
            }
        }
        //this pretty much checks if method is in delegate
        static bool IsMethodInDelegate(LogHandler logHandler, LogHandler method)
        {
            if (logHandler == null)
            {//do we at least have osmething in logHandler?
                return false;
            }
            foreach (var d in logHandler.GetInvocationList())
            {//is everything in logHandler delegate

                if (d == (Delegate)method)//we take method and cast it into delegate
                {
                    return true;
                }
            }
            return false;
        }
    }
}
