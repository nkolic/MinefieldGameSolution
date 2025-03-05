using Xunit;

public class BoardTests
{
    [Fact]
    public void Board_ShouldHaveCorrectDimensions()
    {
        var board = new Board(5, 5, 3);
        Assert.Equal(5, board.Rows);
        Assert.Equal(5, board.Columns);
    }

    [Fact]
    public void IsMine_ShouldReturnTrueForMinePosition()
    {
        var board = new Board(5, 5, 25);
        Assert.True(board.IsMine(0, 0));
        Assert.True(board.IsMine(4, 4));
    }

    [Fact]
    public void IsMine_ShouldReturnFalseForNonMinePosition()
    {
        var board = new Board(5, 5, 0);
        Assert.False(board.IsMine(2, 2));
    }
}