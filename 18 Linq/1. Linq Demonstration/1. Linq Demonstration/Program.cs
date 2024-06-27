namespace _1._Linq_Demonstration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] {1,2,3,4,5,6,7,8,9};
            //get all odd numbers
            OddNumbers(numbers);
            Console.ReadKey();
        }

        static void OddNumbers(int[] numbers)
        {
            Console.WriteLine("Odd Numbers:");
            //chekc every single number in numbers chck if diivdible by 2 without reminder
            //if does add to our oddNumbers list; where is filtering operator and then selec is projection
            //operator - what will be returned
            IEnumerable<int> oddNumbers =from number in numbers where number % 2 != 0 select number;
            Console.WriteLine(oddNumbers);

            foreach (int i in oddNumbers) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
