using Microsoft.AspNetCore.Mvc;
using RealEstateDataTool.Service;

namespace RealEstateDataTool.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWebScraperService _scraper;

        public WeatherForecastController(IWebScraperService scraper)
        {
            _scraper = scraper;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public string Get()
        {
            return _scraper.GetData();
        }
    }
}