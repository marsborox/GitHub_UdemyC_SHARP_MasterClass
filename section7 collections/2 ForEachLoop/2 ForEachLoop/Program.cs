namespace _2_ForEachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            
            for (int i = 0; i < 10; i++) // for index 0 value 10 index1 vlaue 11 index 2 value 12..... 19
            {
                nums[i] = i+10;
            }
            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Element {0} = {1}", j, nums[j]);
            }

            Console.WriteLine("break");

            int counter = 0;
             foreach (int k in nums)    //create variable run it through the whole array k is value in specific index in nums
             {
                 Console.WriteLine("Element {0} = {1}",counter, k);counter++; //to counter ++ je iba na to aby to vypluvalo aj cislo countera
             }                                                                  // inak by to dalo spravne outputy ale counter by sa volal stale 0

            string[] friends = new string[5];
            friends[0] = "Jozo";
            friends[1] = "Betty";
            friends[2] = "Takac";
            friends[3] = "Jano";
            friends[4] = "Ondrej";

            foreach (string f in friends) 
            {
                Console.WriteLine("Ahoj {0}",f);
            }

            string[] friends2 = { "A", "B", "C", "D", "E" };

            foreach (string f in friends2)
            {
                Console.WriteLine("Ahoj {0}", f);
            }



        }
    }
}
