using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PessoaAPI.Model;
using PessoaAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PessoaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        //private readonly IPessoaService _pessoaService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetAll")]
        public List<PessoaModel> GetAll([FromServices] IPessoaService _pessoaService)
        {
            return _pessoaService.GetPessoa();
        }

        [HttpGet("GetId")]
        public PessoaModel GetById(int id, [FromServices] IPessoaService _pessoaService)
        {
            return _pessoaService.GetById(id);
        }
    }
}
