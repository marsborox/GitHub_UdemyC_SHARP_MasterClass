namespace _1_Introduction_to_delegates
{
    //declaration of delegate can be outside of class as well
    public delegate void Notify3(string msg);
    internal class Program
    {
        //1. Declaration
        public delegate void Notify(string message);
        static void Main(string[] args)
        {
            //Delegates define a method signature,
            //and any method assigned to a delegate must match the signature

            // 2. INstantination
            //Notify , name of delegate
            Notify notifyDelegate = ShowMessage;

            //old way dont do anymore
            Notify notifyDelegate2= new Notify (notifyDelegate);

            // 3. Invocation

            notifyDelegate("Message");
        }
        static void ShowMessage(string message)
        {//we use this method to isntantiatethe delegate
            Console.WriteLine( message);
        }
    }
}
