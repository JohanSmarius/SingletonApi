using System.Diagnostics;

namespace SingletonApi;

public class SomeOtherGenerator
{
    private readonly NumberGenerator _numberGenerator;
    private readonly int _number;

    public SomeOtherGenerator(NumberGenerator numberGenerator)
    {
        Debug.WriteLine("SomeOtherGenerator created");
        _numberGenerator = numberGenerator;
        _number = _numberGenerator.GetRandomNumber();
    }
    
    public int Generate()
    {
        return _number;
    }
}