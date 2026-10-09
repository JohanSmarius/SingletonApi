using System.Diagnostics;

namespace SingletonApi;

public class NumberGenerator
{
    private readonly int _number = Random.Shared.Next(1, 100);

    public NumberGenerator()
    {
        Debug.WriteLine("NumberGenerator created");
    }
    
    public int GetRandomNumber()
    {
        return _number;
    }
}