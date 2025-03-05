
public class Board
{
    public int Rows { get; }
    public int Columns { get; }

    private readonly bool[,] mines;

    public Board (int rows, int columns, int mineCount)
    {
        Rows = rows;
        Columns = columns;
        mines = new bool[rows, columns];
        // TODO generate mines
    }

    public void DisplayBoard(Player player)
    {
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Columns; j++)
            {
                if (player.X == i && player.Y == j)
                    Console.Write(" P ");
                else
                    Console.Write(" . ");
            }
            Console.WriteLine();
        }
    }
}