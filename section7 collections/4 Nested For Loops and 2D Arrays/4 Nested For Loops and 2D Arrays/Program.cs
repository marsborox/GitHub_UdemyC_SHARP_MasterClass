using System.ComponentModel.DataAnnotations;

namespace _4_Nested_For_Loops_and_2D_Arrays
{
    internal class Program
    {
        static int[,] matrix =
        {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };
        static void Main(string[] args)
        {
            foreach (int item in matrix) // tu vlastne len storujem value akoze tu som si povedal 
            {                               //ze sa vola item
                Console.WriteLine(item + " ");
            }
            
            Console.WriteLine("This is our 2D array printed using nested for loop");
            /*for (int i = 0; i < matrix.GetLength(0); i++) //outter for loop
            {
                for (int j = 0; j < matrix.GetLength(0); j++) //inner for loop
                {
                    int number = matrix[i, j];
                    if (i+j == 2) { Console.WriteLine(number);}
                    else { Console.WriteLine(" "); }

                }
            }*/
            for (int i = 0, j = 2; i < matrix.GetLength(0); i++, j--) //start on
            {
                Console.WriteLine(matrix[i,j]);
            }
        }
    }
}
