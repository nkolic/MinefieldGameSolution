using Xunit;

public class PlayerTests
{
    [Fact]
    public void Player_ShouldStartAtGivenPosition()
    {
        var player = new Player(0, 0, 3);
        Assert.Equal(0, player.X);
        Assert.Equal(0, player.Y);
    }

    [Fact]
    public void Move_ShouldUpdatePlayerPosition()
    {
        var player = new Player(0, 0, 3);
        player.Move(2, 3);
        Assert.Equal(2, player.X);
        Assert.Equal(3, player.Y);
    }

}