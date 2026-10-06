using Microsoft.AspNetCore.Mvc;

namespace SingletonApi.Controllers;

[ApiController]
[Route("[controller]")]
public class RandomController : ControllerBase
{

    [HttpGet(Name = "GetWeatherForecast")]
    public int Get()
    {
        return
            
    }
}