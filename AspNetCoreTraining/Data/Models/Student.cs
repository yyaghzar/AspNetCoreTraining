using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AspNetCoreTraining.Data.Models
{
    public class Student : IEntity
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        [JsonIgnore]
        public ICollection<Enrollment> Enrollments { get; set; }
    }
    
}
