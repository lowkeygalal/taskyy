using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskyy.Models
{
    internal class Course
    {
        public int CourseId { get; set; } 
        public string Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentId { get; set; }
        public Department NavDepartment { get; set; }
        public ICollection<Enrollment> NavEnrollment { get; set; }
        public ICollection<CourseSchedule> NavCourseSchedule { get; set; }
        public ICollection<Exam> NavExam { get; set; }
        public ICollection<Assignment> NavAssignment { get; set; }
        /*Represents academic courses offered by departments.
Columns
•	CourseId (PK, int, identity).
•	Title (nvarchar(200), required).
•	Credits (int, required, >0).
•	DepartmentId (FK → Departments).
Relationships
•	One Course belongs to one Department.
•	Courses have many Enrollments (Students).
•	Courses have many Assignments and Exams.
•	Courses are scheduled with Instructors and Classrooms.
*/



    }
}
