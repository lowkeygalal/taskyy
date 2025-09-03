using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskyy.Models
{
    internal class Instructor
    {
        public int InstructorId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        public DateOnly HireDate { get; set; }
        public int DepartmentId { get; set; }
        public Department NavDepartment { get; set; }
        public Department NavHeadOfDepartment { get; set; }
        public ICollection<CourseSchedule> NavCourseSchedule { get; set; }
        /*Represents teaching staff.
 Columns
 •	InstructorId (PK, int, identity).
 •	FullName (nvarchar(200), required).
 •	Email (nvarchar(150), required, unique).
 •	Phone (nvarchar(20), optional).
 •	HireDate (date, required).
 •	DepartmentId (FK → Departments).
 Relationships
 •	One Instructor belongs to one Department.
 •	One Instructor can teach many Courses via CourseSchedules.
 •	One Instructor can be Head of a Department.
 */


    }
}
