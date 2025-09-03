using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskyy.Models
{
    internal class CourseSchedule
    {
        public int ScheduleId { get; set; }
        public int CourseId { get; set; }
        public Course NavCourse { get; set; }
        public int InstructorId { get; set; }
        public Instructor NavInstructor { get; set; }
        public int ClassroomId { get; set; }
        public Classroom NavClassroom { get; set; }
        public string DayOfWeek { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        /*Represents the scheduling of a course with an instructor and a classroom.
Columns
•	ScheduleId (PK, int, identity).
•	CourseId (FK → Courses).
•	InstructorId (FK → Instructors).
•	ClassroomId (FK → Classrooms).
•	DayOfWeek (nvarchar(20), required).
•	StartTime (time, required).
•	EndTime (time, required).
Relationships
•	Each schedule links a Course, Instructor, and Classroom
*/

    }
}
