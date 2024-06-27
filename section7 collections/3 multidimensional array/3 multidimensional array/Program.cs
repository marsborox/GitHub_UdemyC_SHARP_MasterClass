namespace _3_multidimensional_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] matrix; //2D array

            int[,,] threeDarray; //3D array seems can go further


            //  here idefine it     from word new i am creating it, define dimensions in [,]
            int[,] array2D = new int[,] //matrix created
            {
                {1,2,3},    //row0
                {4,5,6},    //row1
                {7,8,9},    //row2
            };

            Console.WriteLine("Central value is {0}", array2D[1,1]); // row 1, index1 in that row - number 5, [2,0] will be 7
            Console.ReadLine();
            string[,,] array3D = new string[,,]
                {
                    {
                        {"000","001" },
                        {"010","011" }
                    },
                    {
                        {"100","101" },
                        {"110","111" }
                    }
                };
            Console.WriteLine("3d value is {0}", array3D [1,1,0]);

            string[,] array2Dstring = new string[3, 2] 
            { 
                {"one" ,"two" },
                {"three" ,"four"},
                {"five" ,"six" } 
            };

            array2Dstring[1, 1] = "chicken";

            int dimensions = array2Dstring.Rank; // rank gets dimensons of array

            Console.WriteLine("2d array dimensions are {0}",dimensions); //2dimensional array
            Console.WriteLine("value {0}", array2Dstring[1,1]);


            int[,] array2D2 = //will automaticly know its 2D rank
            {
                { 1,2},
                { 3,4}
            };
        }
    }
}
