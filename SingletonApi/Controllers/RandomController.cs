using System.Runtime.InteropServices.JavaScript;
using Microsoft.AspNetCore.Mvc;

namespace SingletonApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RandomController : ControllerBase
{
    private readonly NumberGenerator _numberGenerator;

    public RandomController(NumberGenerator numberGenerator)
    {
        _numberGenerator = numberGenerator;
    }
    
    
    [HttpGet(Name = "GetRandom")]
    public int Get()
    {
        return _numberGenerator.GetNumber();
    }
}