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

    [HttpGet(Name = "GetRandomNumber")]
    public List<int> Get()
    {
        return [_numberGenerator.GetRandomNumber(), _someOtherGenerator.Generate()];
    }
}