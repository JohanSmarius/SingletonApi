namespace SingletonApi;

public class NumberGenerator
{
    private readonly int _number = new Random().Next(1, 100);
    
    public int GetNumber()
    {
        return _number;
    }
}