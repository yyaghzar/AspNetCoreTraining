using AspNetCoreTraining.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTraining.Data.Repos
{
    public class EnrollmentRepo : BaseRepo<Enrollment, TrainingContext>
    {
        public EnrollmentRepo(TrainingContext context) : base(context) { }

    }
}
