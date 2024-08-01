namespace _4b._5.EventsDelegates_Example
{
    public delegate void TemperatureChangeHandler(string message);

    public class TemperatureMonitor
    { 
        public event TemperatureChangeHandler OnTemperatureChanged;

        private int _temperature;
        public int Temperature { get { return _temperature; } 
            
            set 
            {//logic is when we set temperature there are some rules
                //if temp above 30 event will be raised
                _temperature = value;
                if (_temperature > 30)
                {
                    //raise event
                    RaiseTemperatureChangedEvent("temperature is above 30 degrees");
                }
                if (_temperature < 0)
                {
                    RaiseTemperatureChangedEvent("It is cold");
                }
            }
        }

        protected virtual void RaiseTemperatureChangedEvent(string message)
        { //we invoke all subscribers
            OnTemperatureChanged?.Invoke(message);
        }
    }
    public class TemperatureAlert
    {
        public void OnTemperatureChanged(string message)
        {
            Console.WriteLine("Alert: " + message);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureMonitor monitor = new TemperatureMonitor();
            TemperatureAlert alert = new TemperatureAlert();

            monitor.OnTemperatureChanged += alert.OnTemperatureChanged;

            monitor.Temperature = 20;
            Console.WriteLine("Enter temperature");
            monitor.Temperature = int.Parse ( Console.ReadLine());

            Console.ReadKey();
        }
    }
}
