using System.Runtime.InteropServices;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5]; //create array = initialize array  it will have 5 values
            grades[0] = 20; // we assign value to specific index
            grades[1] = 30;
            grades[2] = 35;
            grades[3] = 28;
            grades[4] = 11;

            Console.WriteLine("pick index 0-4");
            string input= Console.ReadLine();
            grades[0] = int.Parse(input);
            Console.WriteLine(  "grades at index 0 : {0}",grades[0]);
            Console.ReadKey();

            int[] gradesOfMathStudentA = { 20, 13, 12, 8, 8 }; //only 5 values
            int[] gradesOfMathStudentB = new int[] { 15, 13, 20, 5, 8, 10};  // has 6 values
            Console.WriteLine("length of gradesOfMathStudentA: {0}", gradesOfMathStudentA.Length); // outputs length of array



        }
    }
}
