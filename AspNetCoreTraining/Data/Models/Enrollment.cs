using System.Text.Json.Serialization;

namespace AspNetCoreTraining.Data.Models
{
    public class Enrollment : IEntity
    {
        public int ID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }
        [JsonIgnore]
        public Course Course { get; set; }
        [JsonIgnore]
        public Student Student { get; set; }
    }
    public enum Grade
    {
        A, B, C, D, F
    }
}
