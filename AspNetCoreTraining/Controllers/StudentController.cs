using AspNetCoreTraining.Data.Models;
using AspNetCoreTraining.Data.Repos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AspNetCoreTraining.Controllers
{
    public class StudentController : BaseAppController<Student, StudentRepo>
    {
        private readonly ILogger<StudentController> _logger;
        public StudentController(StudentRepo repo, ILogger<StudentController> logger) : base(repo)
        {
            _logger = logger;
        }

        [HttpGet("Header")]
        public string GetHeader() {
            var header = Request.Headers["X-Testing"];
            return header;
        }

    }
}