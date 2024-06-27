namespace _2_first_inheritance
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Radio myRadio = new Radio(false, "Sony");
            myRadio.SwitchOn();
            myRadio.ListenRadio();
            TV myTV = new TV(false, "ChangChong");
            myTV.SwitchOn();
            myTV.WatchTv();
        }
    }
}
