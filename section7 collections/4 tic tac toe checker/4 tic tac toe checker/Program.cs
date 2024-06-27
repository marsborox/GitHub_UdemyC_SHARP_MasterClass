namespace _4_tic_tac_toe_checker
{
    internal class Program
    {
        //create playfield
        static char[,] playField =
        {
            {'1','2','3'},
            {'4','5','6'},
            {'6','7','8'}
        };


       /* public class TicTacToe
        {
            public static bool Checker(string[,] board)
            {
                // here we perform horizontal and vertical checks
                for (int i = 0; i < 3; i++)
                {
                    if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                        return true;
                    if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
                        return true;
                }
                // here diagonal checks 
                if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                    return true;
                if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                    return true;
                return false;
            }*/

            static void Main(string[] args) 
            {
                SetField();
            Console.ReadKey();
            }

            public static void SetField()
            {
                Console.WriteLine("   |   |   ");
                Console.WriteLine(" {0} | {1} | {2} ", playField[0,0], playField[0,1], playField[0,2]);
                Console.WriteLine("___|___|___");
                Console.WriteLine("   |   |   ");
                Console.WriteLine(" {0} | {1} | {2} ", playField[1,0], playField[1,1], playField[1,2]);
                Console.WriteLine("___|___|___");
                Console.WriteLine("   |   |   ");
                Console.WriteLine(" {0} | {1} | {2} ", playField[2,0], playField[2,1], playField[2,2]);
                Console.WriteLine("   |   |   ");
            }

        
        
    }
}
