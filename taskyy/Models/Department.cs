using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskyy.Models
{
    internal class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string? OfficeLocation { get; set; }
        public int? HeadOfDepartmentId { get; set; }
        public Instructor? NavHeadOfDepartment { get; set; }
        public ICollection<Student> NavStudent { get; set; }
        public ICollection<Instructor> NavInstructor { get; set; }
        public ICollection<Course> NavCourse { get; set; }

        /*Columns
 •	DepartmentId (PK, int, identity).
 •	Name (nvarchar(200), required, unique).
 •	OfficeLocation (nvarchar(100), optional).
 •	HeadOfDepartmentId (FK → Instructors, nullable).
 Relationships
 •	One Department has many Students, Instructors, and Courses.
 •	HeadOfDepartment is an Instructor (nullable).
 */


    }
}
