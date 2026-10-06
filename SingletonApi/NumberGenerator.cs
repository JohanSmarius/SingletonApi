namespace SingletonApi;

public class NumberGenerator
{
    private readonly int _number = Random.Shared.Next(1, 100);

    public int GetRandomNumber()
    {
        return _number;
    }
}