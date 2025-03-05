
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
        GenerateMines(mineCount);
    }

      private void GenerateMines(int mineCount)
    {
        Random rand = new Random();
        int count = 0;
        while (count < mineCount)
        {
            int x = rand.Next(Rows);
            int y = rand.Next(Columns);
            if (!mines[x, y])
            {
                mines[x, y] = true;
                count++;
            }
        }
    }

    public bool IsMine(int x, int y) => mines[x, y];

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