using BlazorApp.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorApp;

[Route("api/[controller]")]
[ApiController]
public class ForecastController : ControllerBase
{
  public async Task<ActionResult<IEnumerable<WeatherForecast>>> GetFromJsonAsync()
  {
    var svc = new WeatherForecastService();
    return new OkObjectResult(await svc.GetForecastAsync(DateOnly.FromDateTime(DateTime.Now)));
  }
}

