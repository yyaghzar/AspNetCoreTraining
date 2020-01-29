using AspNetCoreTraining.Data.Models;
using AspNetCoreTraining.Data.Repos;
using Microsoft.Extensions.Logging;

namespace AspNetCoreTraining.Controllers
{
    public class CourseController : BaseAppController<Course, CourseRepo>
    {
        private readonly ILogger<CourseController> _logger;
        public CourseController(CourseRepo repo, ILogger<CourseController> logger) : base(repo)
        {
            _logger = logger;
        }

    }
}