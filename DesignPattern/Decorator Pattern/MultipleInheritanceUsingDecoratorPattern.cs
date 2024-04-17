namespace DesignPattern;
public interface IBird
{
    void Fly();
    int Weight { get; set; }
}

public class Bird : IBird
{
    public void Fly()
    {
        Console.WriteLine("soaring in the sky");
    }

    public int Weight { get; set; }
}

public interface ILizard
{
    void Crawl();
    int Weight { get; set; }
}

public class Lizard : ILizard
{
    public void Crawl()
    {
        Console.WriteLine("crawling in the dirt");
    }
    public int Weight { get; set; }
}
public class Dragon : IBird, ILizard
{
    private Bird bird = new();
    private Lizard lizard = new();
    private int _weight;

    public void Fly()
    {
        bird.Fly();
    }

    public void Crawl()
    {
        lizard.Crawl();
    }

    public int Weight
    {
        get => _weight;
        set
        {
            _weight = value;
            bird.Weight = value;
            lizard.Weight = value;
        }
    }
}