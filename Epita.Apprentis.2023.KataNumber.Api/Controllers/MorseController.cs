using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Epita.Apprentis._2023.KataNumber.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MorseController : ControllerBase
    {
        private readonly ILogger<MorseController> _logger;
        private readonly IMorseConverter _converter;

        public MorseController(ILogger<MorseController> logger, IMorseConverter converter)
        {
            _logger = logger;
            _converter = converter;
        }

        [HttpGet("to")]
        public string ToMorse(string number)
        {
            return _converter.ToMorse(number);
        }

        [HttpGet("from")]
        public string FromMorse([FromBody] string text)
        {
            return _converter.FromMorse(text);
        }
    }
}
