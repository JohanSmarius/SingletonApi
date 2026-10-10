using System.Diagnostics;

namespace SingletonApi;

public class NumberGenerator
{
    public Guid InstanceId { get; } = Guid.NewGuid();
    private readonly List<int> _history = [];

    public NumberGenerator()
    {
        Debug.WriteLine($"NumberGenerator created: {InstanceId}");
    }

    public void AddNumber(int number)
    {
        _history.Add(number);
    }

    public int HistoryCount => _history.Count;
    public IReadOnlyList<int> History => _history;
}