using Microsoft.AspNetCore.Mvc;

namespace SingletonApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RandomController : ControllerBase
{
    private readonly NumberGenerator _numberGenerator;
    private readonly SomeOtherGenerator _someOtherGenerator;

    public RandomController(NumberGenerator numberGenerator, SomeOtherGenerator someOtherGenerator)
    {
        _numberGenerator = numberGenerator;
        _someOtherGenerator = someOtherGenerator;
    }

    [HttpGet]
    public IActionResult Get()
    {
        _numberGenerator.AddNumber(Random.Shared.Next(1, 100));
        _someOtherGenerator.Process(Random.Shared.Next(1, 100));

        return Ok(new
        {
            NumberInstances = new
            {
                InstanceId = _numberGenerator.InstanceId,
                ItemsInHistoryList = _numberGenerator.HistoryCount
            },
            SomeOtherGeneratorInstances = new
            {
                InstanceId = _someOtherGenerator.CapturedInstanceId,
                ItemsInHistoryList = _someOtherGenerator.GetHistoryCount()
            }
        });
    }
}