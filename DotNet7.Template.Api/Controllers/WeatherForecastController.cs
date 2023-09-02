using AutoMapper;
using DotNet7.Template.Api.Models.ViewModels;
using DotNet7.Template.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotNet7.Template.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IMapper _mapper;
        private readonly IWeatherService _weatherService;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger,
            IMapper mapper,
            IWeatherService weatherService)
        {
            _logger = logger;
            _mapper = mapper;
            _weatherService = weatherService;
        }

        [HttpGet("GetWeatherForecast")]
        public List<WeatherForecastViewModel> Get()
        {
            return _mapper.Map<List<WeatherForecastViewModel>>(
                _weatherService.Get());
        }
    }
}