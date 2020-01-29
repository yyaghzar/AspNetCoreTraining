using AspNetCoreTraining.Data.Models;
using AspNetCoreTraining.Data.Repos;
using Microsoft.Extensions.Logging;

namespace AspNetCoreTraining.Controllers
{
    public class EnrollmentController : BaseAppController<Enrollment, EnrollmentRepo>
    {
        private readonly ILogger<EnrollmentController> _logger;
        public EnrollmentController(EnrollmentRepo repo, ILogger<EnrollmentController> logger) : base(repo)
        {
            _logger = logger;
        }

    }
}