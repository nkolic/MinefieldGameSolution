class Program
{
    static void Main()
    {
        Board board = new Board(8, 8, 5);
        Player player = new Player(0, 0, 5);
        GameEngine game = new GameEngine(board, player);

        game.StartGame();
    }
}