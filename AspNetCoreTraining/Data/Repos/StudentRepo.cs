using AspNetCoreTraining.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTraining.Data.Repos
{
    public class StudentRepo:BaseRepo<Student,TrainingContext>
    {
        public StudentRepo(TrainingContext context) : base(context) { }
        
    }
}
