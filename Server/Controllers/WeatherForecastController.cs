using Microsoft.AspNetCore.Mvc;
using Model;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Forma.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : Controller
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<object> data = new()
            {
                new Date(DateTime.Now, "Date"),
                new RadioButton(false,"RadioButton"),
                new TextInput("Text1", "TextInput"),
                new Date(DateTime.Now,"Date"),
                new TextInput("Text2", "TextInput")               
            };

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            return Json(data, options);
        }

        [HttpPost]
        [Route("{action}")]
        public IActionResult PostForm(List<FormType<object>>  forms)
        {
            List<FormType<object>> listForm = forms;           
            return Ok();
        }
    }
}
