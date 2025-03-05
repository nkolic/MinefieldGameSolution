public class Player
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public int Lives { get; private set; }
    public int Moves { get; private set; } = 0;

    public Player(int startX, int startY, int numberOfLives = 3)
    {
        X = startX;
        Y = startY;
        Lives = numberOfLives;
    }

    public void Move(int newX, int newY)
    {
        X = newX;
        Y = newY;
        Moves++;
    }

    public void LoseLife() => Lives--;
}