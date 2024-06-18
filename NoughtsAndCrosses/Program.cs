namespace NoughtsAndCrosses
{
    internal class Program
    {

        static char[,] board = new char[3, 3];


        static void Main(string[] args)
        {

            int[] test = new int[2];

            test[3] = 4;

            int row, column;

            ClearBoard();

            while (true)
            {

                Console.WriteLine("Player X");

                Console.WriteLine("Please enter the row number");

                row = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the column number");

                column = int.Parse(Console.ReadLine());

                if (board[row, column] == '_')
                {
                    board[row, column] = 'X';
                }

                Console.WriteLine("Player 0");

                Console.WriteLine("Please enter the row number");

                row = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the column number");

                column = int.Parse(Console.ReadLine());

                board[row, column] = '0';

                PrintBoard();

            }

            static void PrintBoard()
            {
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int j = 0; j < board.GetLength(1); j++)
                    {
                        Console.Write(board[i, j]);
                    }
                    Console.WriteLine();
                }
            }



            static void ClearBoard()
            {
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int j = 0; j < board.GetLength(1); j++)
                    {
                        board[i, j] = '_';
                    }
                }
            }
        }
    }
}