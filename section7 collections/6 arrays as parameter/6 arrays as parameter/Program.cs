namespace _6_arrays_as_parameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] studentGrades = new int[] { 15, 13, 8, 12, 6, 16 };
            double averageResult = GetAverage(studentGrades);

            foreach(int grade in studentGrades) 
            {
                Console.WriteLine("{0}", grade);
            }

            Console.WriteLine("The Average is {0}",averageResult);
            Console.ReadKey();


            int[] happiness = new int[] { 5, 8, 10, 7, 8 };
            GetHappiness(happiness);

            foreach (int happy in happiness)
            {
                Console.WriteLine("{0}", happy);
            }
        }
        static void GetHappiness(int[] happiness) 
        {
            for (int i = 0; i < happiness.Length; i++)
                happiness[i] += 2;
        }
        static double GetAverage(int[] gradesArray)
        {
        int size = gradesArray.Length;
        double average;
        int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }
            average = (double)sum / size;
            return average;
        }
    }
}
