using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Model;
using Model.DTO;
using System.Text.Json;


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
            List<IInputForForm<object>> data = new ()
            {
                new InputDTO<IFormType<bool>>(new CheckInput(false),"RadioButton"),
                new InputDTO<IFormType<DateTime>>(new DateInput(DateTime.Now),"Date"),
                new InputDTO<IFormType<string>>(new TextInput("Text1"),"TextInput"),
                new InputDTO<IFormType<DateTime>>(new DateInput(DateTime.Now), "Date"),
                new InputDTO<IFormType<bool>>(new CheckInput(false),"RadioButton"),
            };

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };            
            return Json(data, options);
        }

        [HttpPost]
        [Route("{action}")]
        public IActionResult PostForm(List<InputDTO<object>> forms)
        {
            List<InputDTO<object>> listForm = forms;           
            return Ok();
        }
    }
}
