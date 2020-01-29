using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTraining.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GuidController: ControllerBase
    {
        private readonly GuidGenerator _guidGenerator;
        private readonly GuidFactory _guidFactory;
        public GuidController(GuidGenerator  guidGenerator , GuidFactory guidFactory)
        {
            _guidGenerator = guidGenerator;
            _guidFactory = guidFactory;
        }
        [HttpGet]
        public object GetGuid() {

            var result = new { guidGenerator = _guidGenerator.GetGuid(), guidFactory = _guidFactory.GetGuid() };
            return result;
        }

    }

    
}
