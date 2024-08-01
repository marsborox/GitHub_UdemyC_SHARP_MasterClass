namespace _4b._6b_EventArgs_EventHandler
{
    public delegate void TemperatureChangeHandler(string message);

    public class TemperatureChangedEventArgs : EventArgs
    { //***
        //temperature property
        public int Temperature { get; }
        public TemperatureChangedEventArgs(int temperature)
        {//this is pretty much constructor
            //we are storing that temperature in the object of event args
            Temperature = temperature;
        }
    }
    //***
    public class TemperatureMonitor
    {
        public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;
        //public event TemperatureChangeHandler OnTemperatureChanged;

        private int _temperature;
        public int Temperature
        {
            get { return _temperature; }

            set
            {//logic is when we set temperature there are some rules
                //if temp above 30 event will be raised
                
                if (_temperature !=value)
                {//everytime temperature is new temperature
                    //raise event
                    //when we raise event ill give you some event ARGs 
                    //then cal the method
                    _temperature = value;
                    OnTemperatureChanged(new TemperatureChangedEventArgs(value));
                }
            }
        }
        //***
        protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
        { //there is event temperature changed
            //letting all subscribers know about event args
            TemperatureChanged?.Invoke(this, e);
        }
    }
    //subscriber
    public class TemperatureAlert
    {
        public void OnTemperatureChanged(object sender,TemperatureChangedEventArgs e)
        {
            Console.WriteLine($"Alert: temperature is  " + e.Temperature + " sender is: " + sender);
        }
    }

    public class TemperatureAlert2
    {
        public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine($"Alert2: temperature is  " + e.Temperature + " sender is: " + sender);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureMonitor monitor = new TemperatureMonitor();
            TemperatureAlert alert = new TemperatureAlert();
            TemperatureAlert2 alert2 = new TemperatureAlert2();

            monitor.TemperatureChanged += alert.OnTemperatureChanged;
            monitor.TemperatureChanged += alert2.OnTemperatureChanged;

            monitor.Temperature = 20;
            Console.WriteLine("Enter temperature");
            monitor.Temperature = int.Parse(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
