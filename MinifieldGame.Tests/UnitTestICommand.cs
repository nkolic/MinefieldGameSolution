using Xunit;

public class CommandTests
{
    [Fact]
    public void MoveUp_ShouldDecreaseX()
    {
        var player = new Player(2, 2);
        var board = new Board(5, 5, 3);
        var game = new GameEngine(board, player);
        var command = new MoveUp(player, board, game);
        command.Execute();
        Assert.Equal(1, player.X);
        Assert.Equal(2, player.Y);
    }

    [Fact]
    public void MoveDown_ShouldIncreaseX()
    {
        var player = new Player(2, 2);
        var board = new Board(5, 5, 3);
        var game = new GameEngine(board, player);
        var command = new MoveDown(player, board, game);
        command.Execute();
        Assert.Equal(3, player.X);
        Assert.Equal(2, player.Y);
    }

    [Fact]
    public void MoveLeft_ShouldDecreaseY()
    {
        var player = new Player(2, 2);
        var board = new Board(5, 5, 3);
        var game = new GameEngine(board, player);
        var command = new MoveUp(player, board, game);
        command.Execute();
        Assert.Equal(1, player.X);
        Assert.Equal(2, player.Y);
    }

    [Fact]
    public void MoveRight_ShouldIncreaseY()
    {
        var player = new Player(2, 2);
        var board = new Board(5, 5, 3);
        var game = new GameEngine(board, player);
        var command = new MoveRight(player, board, game);
        command.Execute();
        Assert.Equal(2, player.X);
        Assert.Equal(3, player.Y);
    }
}