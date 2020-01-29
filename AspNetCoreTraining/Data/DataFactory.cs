using AspNetCoreTraining.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTraining.Data
{
    public static class DataFactory
    {
        public static Student[] Students { get; set; }
            = new Student[]{
                new Student{ID=1,FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2019-09-01")},
                new Student{ID=2,FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{ID=3,FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Student{ID=4,FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{ID=5,FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{ID=6,FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2016-09-01")},
                new Student{ID=7,FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Student{ID=8,FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2019-09-01")}
            };

        public static Course[] Courses { get; set; }
            = new Course[]{
                new Course{ID=1050,Title="Chemistry",Credits=3},
                new Course{ID=4022,Title="Microeconomics",Credits=3},
                new Course{ID=4041,Title="Macroeconomics",Credits=3},
                new Course{ID=1045,Title="Calculus",Credits=4},
                new Course{ID=3141,Title="Trigonometry",Credits=4},
                new Course{ID=2021,Title="Composition",Credits=3},
                new Course{ID=2042,Title="Literature",Credits=4}
            };

        public static Enrollment[] Enrollments { get; set; }
            = new Enrollment[]{
                new Enrollment{ID=1,StudentID=1,CourseID=1050,Grade=Grade.A},
                new Enrollment{ID=2,StudentID=1,CourseID=4022,Grade=Grade.C},
                new Enrollment{ID=3,StudentID=1,CourseID=4041,Grade=Grade.B},
                new Enrollment{ID=4,StudentID=2,CourseID=1045,Grade=Grade.B},
                new Enrollment{ID=5,StudentID=2,CourseID=3141,Grade=Grade.F},
                new Enrollment{ID=6,StudentID=2,CourseID=2021,Grade=Grade.F},
                new Enrollment{ID=7,StudentID=3,CourseID=1050},
                new Enrollment{ID=8,StudentID=4,CourseID=1050},
                new Enrollment{ID=9,StudentID=4,CourseID=4022,Grade=Grade.F},
                new Enrollment{ID=10,StudentID=5,CourseID=4041,Grade=Grade.C},
                new Enrollment{ID=11,StudentID=6,CourseID=1045},
                new Enrollment{ID=12,StudentID=7,CourseID=3141,Grade=Grade.A},
            };

        
    }
}
