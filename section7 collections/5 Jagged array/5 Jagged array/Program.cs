namespace _5_Jagged_array
{
    internal class Program
    {
        static void Main(string[] args)
        {// declare jagged array
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 13,21 };
                                                // zapisy toho isteho
            int[][] jaggedArray2 = new int[][]
                {
                    new int[] {  2, 3, 5, 7, 11},
                    new int[] { 1, 2, 3 },
                    new int[] { 13,21 }
            };
            //vypluje 5-ku lebo ide od nuly posiiton 0 pozition 2
            Console.WriteLine("test value is {0}", jaggedArray[0][2]);
            Console.WriteLine("test value is {0}", jaggedArray2[0][2]);
            for (int i = 0; i < jaggedArray2.Length; i++)
                {
                Console.WriteLine("element {0}",i);
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                    Console.WriteLine( " is {0}",jaggedArray2[i][j]); ;
            }
        }
    }
}
