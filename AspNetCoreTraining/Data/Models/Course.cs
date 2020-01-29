using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AspNetCoreTraining.Data.Models
{
    public class Course: IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        [JsonIgnore]
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
