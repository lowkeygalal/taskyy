using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskyy.Models
{
    internal class Classroom
    {
        public int ClassroomId { get; set; } 
        public string Building { get; set; }
        public string RoomNumber { get; set; }
        public int Capacity { get; set; }
        public ICollection<CourseSchedule> NavCourseSchedule {  get; set; }
        /*Represents physical classrooms.
Columns
•	ClassroomId (PK, int, identity).
•	Building (nvarchar(100), required).
•	RoomNumber (nvarchar(50), required).
•	Capacity (int, required, >0).
Relationships
•	Classrooms are linked to Courses via CourseSchedules.
*/




    }
}
