namespace _7_params_find_lowest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int min = MinV2(6, 4, 2, 8, 0, 1, 5); //funkcia s parametrami
            Console.WriteLine("minimum is {0}",min);


        }
        public static int MinV2(params int[] numbers)
        {
            int min = int.MaxValue; //max value of integer 2 bilion
            foreach (int number in numbers) // vojde do int min a precitacislo ide s nim dalej
            {
                if (number < min)  //will check if number is lower "min"
                    min = number;  //if yes enterend number is our min
            }
            return min;
        }
    }
}
