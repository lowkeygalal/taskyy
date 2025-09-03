using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskyy.Models
{
    internal class Exam
    {
        public int ExamId { get; set; }
        public int CourseId { get; set; }
        public Course NavCourse { get; set; }
        public DateTime ExamDate { get; set; }
        public string Type { get; set; }
        public ICollection<ExamResult> NavExamResult { get; set; }
        /*Represents exams for courses.
 Columns
 •	ExamId (PK, int, identity).
 •	CourseId (FK → Courses).
 •	ExamDate (datetime, required).
 •	Type (nvarchar(50), required: Midterm/Final).
 Relationships
 •	Exams belong to a Course.
 •	Exams have many ExamResults.
 */
    }
}
