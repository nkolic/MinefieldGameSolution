public interface IGameObserver
{
    void Update(Player player);
}

public class ConsoleGameObserver : IGameObserver
{
    public void Update(Player player)
    {
        Console.WriteLine($"Player Moved: ({player.X}, {player.Y}) | Lives: {player.Lives} | Moves: {player.Moves}");
    }
}