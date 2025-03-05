public interface ICommand
{
    void Execute();
}

public class MoveUp : ICommand
{
    private readonly Player _player;
    private readonly Board _board;
    private readonly GameEngine _game;

    public MoveUp(Player player, Board board, GameEngine game)
    {
        _player = player;
        _board = board;
        _game = game;
    }

    public void Execute()
    {
        if (_player.X > 0) _player.Move(_player.X - 1, _player.Y);
        _game.CheckMine();
    }
}

public class MoveDown : ICommand
{
    private readonly Player _player;
    private readonly Board _board;
    private readonly GameEngine _game;

    public MoveDown(Player player, Board board, GameEngine game)
    {
        _player = player;
        _board = board;
        _game = game;
    }

    public void Execute()
    {
        if (_player.X < _board.Rows) _player.Move(_player.X + 1, _player.Y);
        _game.CheckMine();
    }
}

public class MoveLeft : ICommand
{
    private readonly Player _player;
    private readonly Board _board;
    private readonly GameEngine _game;

    public MoveLeft(Player player, Board board, GameEngine game)
    {
        _player = player;
        _board = board;
        _game = game;
    }

    public void Execute()
    {
        if (_player.Y > 0) _player.Move(_player.X, _player.Y - 1);
        _game.CheckMine();
    }
}

public class MoveRight : ICommand
{
    private readonly Player _player;
    private readonly Board _board;
    private readonly GameEngine _game;

    public MoveRight(Player player, Board board, GameEngine game)
    {
        _player = player;
        _board = board;
        _game = game;
    }

    public void Execute()
    {
        if (_player.Y < _board.Columns) _player.Move(_player.X, _player.Y + 1);
        _game.CheckMine();
    }
}
