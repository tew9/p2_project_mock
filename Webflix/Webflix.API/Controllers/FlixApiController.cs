using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Webflix.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlixApiController : ControllerBase
    {
        private readonly ILogger<FlixApiController> _logger;
        private static readonly List<FlixModel> _fml = new List<FlixModel>()
        {
          new FlixModel(){Title = "X-Men"},
          new FlixModel(){ Title = "WatchMen"},
          new FlixModel(){ Title = "Super Man"},
          new FlixModel(){ Title = "Iron Man"}
        };

        [HttpGet]
        public IEnumerable<FlixModel> Get()
        {
           return _fml;
        }

        public IEnumerable<FlixModel> Get(FlixModel model)
        {
          if(ModelState.IsValid)
          {
            _fml.Add(model);
          }
           return _fml;
        }
    }
}
