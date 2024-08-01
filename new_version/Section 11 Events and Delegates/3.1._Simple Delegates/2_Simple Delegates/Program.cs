namespace _2_Simple_Delegates
{
    public delegate void LogHandler(string message);
    //So if you want to use the log handler, we need to make sure that the method that we assign to it follows
    //the same declaration.

    public class Logger
    {//here we define methods
        public void LogToConsole(string message)
        {
            Console.WriteLine("Console Log: "+ message);
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
            //this will print "Logging to console" into console
            logHandler("Logging to console");
            //we can override logHandler with another method
            logHandler = logger.LogToFile;
            logHandler("Logging to file");

        }
    }
}
