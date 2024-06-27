using System.Threading.Channels;

namespace IEnumerable_example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> unknownCollection;
            unknownCollection = GetCollection(1);

            Console.WriteLine("This was a list <int>");
            //for each number in the collection we got back from GetCollection(1);
            foreach (int num in unknownCollection) 
            {
                Console.WriteLine(num + " ");
            }
            Console.WriteLine("");
            //call GetCollection() with option = 2 which will return a Queue<int>
            //but will store it in the base type of generic colelctions
            //So unknown collection is the base type I enumerable,
            //which is basically the base type of our list and Queue
            unknownCollection = GetCollection(2);
            Console.WriteLine("This was a Queue<int>");
            foreach (int num in unknownCollection)
            {
                Console.WriteLine(num + " ");
            }
            unknownCollection = GetCollection(3);
            Console.WriteLine("this was an awway of int");
            foreach (int num in unknownCollection)
            {
                Console.WriteLine(num + " ");
            }
        }
        //will return different type of list we send it
        static IEnumerable<int> GetCollection(int option)
        {   //create a list of numbers initialise it
            List<int> numberslist = new List<int>() {1,2,3,4,5 };

            Queue<int> numbersQueue = new Queue<int>();
            // add values to queue
            numbersQueue.Enqueue(6);
            numbersQueue.Enqueue(7);
            numbersQueue.Enqueue(8);
            numbersQueue.Enqueue(9);
            numbersQueue.Enqueue(10);

            if (option == 1)
            {
                return numberslist;
            }
            else if (option == 2)
            {
                return numbersQueue;
            }
            else
            {
                return new int[] {11,12,13,14,15};
            }
        }
    }
}
