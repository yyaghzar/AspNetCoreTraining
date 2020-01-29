using AspNetCoreTraining.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTraining.Data.Repos
{
    public class CourseRepo : BaseRepo<Course, TrainingContext>
    {
        public CourseRepo(TrainingContext context) : base(context) { }

    }
}
