namespace DoWhile_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int lenghtOfText = 0;
            string wholeText = "";
            do
            {
                Console.WriteLine("enter name of friend");
                string nameOfFriend = Console.ReadLine(); 
                int currentLength = nameOfFriend.Length;    //added to the length         =       length user entered
                lenghtOfText += currentLength;
                wholeText += nameOfFriend;
               
            } while (lenghtOfText < 20);
            Console.WriteLine("thats enough " + wholeText);
            Console.Read();
        }
    }
}
