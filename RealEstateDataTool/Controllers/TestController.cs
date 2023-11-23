using Microsoft.AspNetCore.Mvc;
using RealEstateDataTool.Domain;
using RealEstateDataTool.Service;

namespace RealEstateDataTool.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController
    {
        private readonly IWebScraperService _scraper;

        public TestController(IWebScraperService scraper)
        {
            _scraper = scraper;
        }

        [HttpGet]
        [Route("GetAd")]
        public AruodasAd GetAd()
        {
            return _scraper.GetAruodasAd();
        }


        [HttpGet] 
        [Route("ResetAd")]
        public IActionResult TestAd()
        {
            return null;
        }
    }
}