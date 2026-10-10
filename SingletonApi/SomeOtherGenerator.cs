using System.Diagnostics;

namespace SingletonApi;

public class SomeOtherGenerator
{
    private readonly NumberGenerator _scopedGenerator;

    public SomeOtherGenerator(NumberGenerator numberGenerator)
    {
        Debug.WriteLine("SomeOtherGenerator created");
        _scopedGenerator = numberGenerator;
    }

    public Guid CapturedInstanceId => _scopedGenerator.InstanceId;

    public void Process(int value)
    {
        _scopedGenerator.AddNumber(value);
    }

    public int GetHistoryCount() => _scopedGenerator.HistoryCount;
}