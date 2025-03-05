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


    public void CheckMine()
    {
        if (_board.IsMine(_player.X, _player.Y))
        {
            _player.LoseLife();
            Console.WriteLine("Mine Hit! You lost a life.");
        }
    }

    public void StartGame()
    {
        while (_player.Lives > 0 && _player.Y < _board.Columns - 1)
        {
            _board.DisplayBoard(_player);
            Console.Write("Move (W/A/S/D): ");
            var move = Console.ReadKey().Key;
            Console.WriteLine();
              ICommand command = move switch
            {
                ConsoleKey.W => new MoveUp(_player, _board, this),
                ConsoleKey.S => new MoveDown(_player, _board, this),
                ConsoleKey.A => new MoveLeft(_player, _board, this),
                ConsoleKey.D => new MoveRight(_player, _board, this),
                _ => null
            };
            command?.Execute();
        }
        Console.WriteLine(_player.Lives > 0 ? "🎉 You Won!" : "💀 Game Over");
    }
}