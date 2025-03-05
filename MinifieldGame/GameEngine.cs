using System;

public class GameEngine
{
    private readonly Board _board;
    private readonly Player _player;

    public GameEngine(Board board, Player player)
    {
        _board = board;
        _player = player;
    }

    public void StartGame()
    {
        _board.DisplayBoard(_player);
        Console.Write("Move (W/A/S/D): ");
    }
}