using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace DemoWebApiProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILoggerManager _logger;
        private IRepositoryWrapper _repositoryWrapper;
        private IMapper _mapper;
        private IConfiguration _configuration;
        public WeatherForecastController(ILoggerManager logger, IRepositoryWrapper repositoryWrapper, IMapper mapper, IConfiguration configuration)
        {
            _logger = logger;
            _repositoryWrapper = repositoryWrapper;
            _mapper = mapper;
            _configuration = configuration; 
        }

        [HttpGet]
        public void GetConfigInfo()
        {
            var mySqlConnection = new MySqlConnection();
            _configuration.Bind("mssqlconnection", mySqlConnection);
            var weatherForecast = new WeatherForecast
            {
                ConStringValue = mySqlConnection.ConnectionString
            };
             
        }
        
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    var domesticAccounts = _repositoryWrapper.AccountRepository.FindByCondition(x => x.AccountType.Equals("s"));
        //    var owners = _repositoryWrapper.OwnerRepository.FindAll();
        //    return new string[] { "value1", "value2" };
        //}
        //[HttpGet]
        //public IActionResult GetAllOwners()
        //{
        //    var owners = _repositoryWrapper.OwnerRepository.FindAll();
        //    var ownersResult = _mapper.Map<IEnumerable<OwnerDto>>(owners);
        //    return Ok(ownersResult);
        //}
    }
}