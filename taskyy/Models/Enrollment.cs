using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskyy.Models
{
    internal class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public Student NavStudent { get; set; }
        public int CourseId { get; set; }
        public Course NavCourse { get; set; }
        public decimal? Grade { get; set; }
        /*Represents the many-to-many relationship between Students and Courses.
Columns
•	EnrollmentId (PK, int, identity).
•	StudentId (FK → Students).
•	CourseId (FK → Courses).
•	Grade (decimal(5,2), optional).
Relationships
•	A Student can enroll in multiple Courses.
•	A Course can have multiple Students.
•	Unique constraint on (StudentId, CourseId).
*/



    }
}
