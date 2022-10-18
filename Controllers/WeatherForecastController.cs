using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Utils;

namespace TestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public partial class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly IConverter _converter;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWebHostEnvironment hostingEnvironment, IConverter converter)
        {
            _logger = logger;
            _converter = converter;
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet("GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        //ToRemove
        [HttpGet("TestListPdf")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(object), 200)]
        public IActionResult TestListPdf()
        {
            try
            {
                var tableConfig = new TableAttributeConfig
                {
                    TableAttributes = new { @class = "tContent" },
                };

                var mainData = new
                {
                    Id = "#007",
                    Fullname = "John Doe",
                    Address = "14B Karimu Ikotun Street, Victoria Island Lagos",
                    Date = DateTime.Now.ToLongDateString()
                };

                var listData = new List<dynamic> { new {
                    SN = "1", Body = "Test PDF Body Data row 1",
                    My = "Test PDF Body Data row 1",
                    My1 = "Test PDF Body Data row 1",
                    My2 = "Test PDF Body Data row 1",
                    My3 = "Test PDF Body Data row 1",
                    My4 = "Test PDF Body Data row 1",
                    My5 = "Test PDF Body Data row 1",
                    My6 = "Test PDF Body Data row 1",
                    My7 = "Test PDF Body Data row 1",
                    My8 = "Test PDF Body Data row 1",
                    My9 = "Test PDF Body Data row 1",
                    My0 = "Test PDF Body Data row 1",
                    Myq = "Test PDF Body Data row 1",
                    Myw = "Test PDF Body Data row 1",
                    Mye = "Test PDF Body Data row 1",
                    Myr = "Test PDF Body Data row 1",
                    Myt = "Test PDF Body Data row 1",
                    Myy = "Test PDF Body Data row 1",
                    Myu = "Test PDF Body Data row 1",
                    Myi = "Test PDF Body Data row 1",
                    Myo = "Test PDF Body Data row 1",
                    Myp = "Test PDF Body Data row 1",
                    Ms = "Test PDF Body Data row 1",
                    Myd = "Test PDF Body Data row 1",
                    Myf = "Test PDF Body Data row 1",
                    Myg = "Test PDF Body Data row 1",
                    Myh = "Test PDF Body Data row 1",
                    Myj = "Test PDF Body Data row 1",
                    Myvb = "Test PDF Body Data row 1",
                    Myffr = "Test PDF Body Data row 1",
                    Myr4 = "Test PDF Body Data row 1",
                    Myb = "Test PDF Body Data row 1",
                    Myghj = "Test PDF Body Data row 1",
                    Mym = "Test PDF Body Data row 1",
                    Myqs = "Test PDF Body Data row 1",
                    Myrf = "Test PDF Body Data row 1",
                },  new {
                    SN = "2", Body = "Test PDF Body Data row 1",
                    My = "Test PDF Body Data row 1",
                    My1 = "Test PDF Body Data row 1",
                    My2 = "Test PDF Body Data row 1",
                    My3 = "Test PDF Body Data row 1",
                    My4 = "Test PDF Body Data row 1",
                    My5 = "Test PDF Body Data row 1",
                    My6 = "Test PDF Body Data row 1",
                    My7 = "Test PDF Body Data row 1",
                    My8 = "Test PDF Body Data row 1",
                    My9 = "Test PDF Body Data row 1",
                    My0 = "Test PDF Body Data row 1",
                    Myq = "Test PDF Body Data row 1",
                    Myw = "Test PDF Body Data row 1",
                    Mye = "Test PDF Body Data row 1",
                    Myr = "Test PDF Body Data row 1",
                    Myt = "Test PDF Body Data row 1",
                    Myy = "Test PDF Body Data row 1",
                    Myu = "Test PDF Body Data row 1",
                    Myi = "Test PDF Body Data row 1",
                    Myo = "Test PDF Body Data row 1",
                    Myp = "Test PDF Body Data row 1",
                    Ms = "Test PDF Body Data row 1",
                    Myd = "Test PDF Body Data row 1",
                    Myf = "Test PDF Body Data row 1",
                    Myg = "Test PDF Body Data row 1",
                    Myh = "Test PDF Body Data row 1",
                    Myj = "Test PDF Body Data row 1",
                    Myvb = "Test PDF Body Data row 1",
                    Myffr = "Test PDF Body Data row 1",
                    Myr4 = "Test PDF Body Data row 1",
                    Myb = "Test PDF Body Data row 1",
                    Myghj = "Test PDF Body Data row 1",
                    Mym = "Test PDF Body Data row 1",
                    Myqs = "Test PDF Body Data row 1",
                    Myrf = "Test PDF Body Data row 1",
                }
                ,  new {
                    SN = "2", Body = "Test PDF Body Data row 1",
                    My = "Test PDF Body Data row 1",
                    My1 = "Test PDF Body Data row 1",
                    My2 = "Test PDF Body Data row 1",
                    My3 = "Test PDF Body Data row 1",
                    My4 = "Test PDF Body Data row 1",
                    My5 = "Test PDF Body Data row 1",
                    My6 = "Test PDF Body Data row 1",
                    My7 = "Test PDF Body Data row 1",
                    My8 = "Test PDF Body Data row 1",
                    My9 = "Test PDF Body Data row 1",
                    My0 = "Test PDF Body Data row 1",
                    Myq = "Test PDF Body Data row 1",
                    Myw = "Test PDF Body Data row 1",
                    Mye = "Test PDF Body Data row 1",
                    Myr = "Test PDF Body Data row 1",
                    Myt = "Test PDF Body Data row 1",
                    Myy = "Test PDF Body Data row 1",
                    Myu = "Test PDF Body Data row 1",
                    Myi = "Test PDF Body Data row 1",
                    Myo = "Test PDF Body Data row 1",
                    Myp = "Test PDF Body Data row 1",
                    Ms = "Test PDF Body Data row 1",
                    Myd = "Test PDF Body Data row 1",
                    Myf = "Test PDF Body Data row 1",
                    Myg = "Test PDF Body Data row 1",
                    Myh = "Test PDF Body Data row 1",
                    Myj = "Test PDF Body Data row 1",
                    Myvb = "Test PDF Body Data row 1",
                    Myffr = "Test PDF Body Data row 1",
                    Myr4 = "Test PDF Body Data row 1",
                    Myb = "Test PDF Body Data row 1",
                    Myghj = "Test PDF Body Data row 1",
                    Mym = "Test PDF Body Data row 1",
                    Myqs = "Test PDF Body Data row 1",
                    Myrf = "Test PDF Body Data row 1",
                } };
                var result = PdfHelper.BuildPdfFile(_converter, _hostingEnvironment, "PdfTemplate/TestPdfTemplate2.html", mainData, listData, tableConfig, isLandscape: true);

                return File(result, "application/octet-stream", "TestListPage.pdf");
            }
            catch (Exception ex)
            {
                return Ok();
            }
        }
    }
}