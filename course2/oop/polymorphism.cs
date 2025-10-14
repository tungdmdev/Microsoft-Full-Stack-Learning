public class Guitar : IPlayable
{
    public void Play()
    {
        Console.WriteLine("The guitar is playing");
    }
}

public class Piano : IPlayable
{
    public void Play()
    {
        Console.WriteLine("The piano is playing");
    }
}