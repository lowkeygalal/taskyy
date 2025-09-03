using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskyy.Models
{
    internal class ExamResult
    {
        public int ExamResultId { get; set; }
        public int ExamId { get; set; }
        public Exam NavExam { get; set; }
        public int StudentId { get; set; }
        public Student NavStudent { get; set; }
        public decimal Score { get; set; }

        /*Represents results of exams for students.
 Columns
 •	ExamResultId (PK, int, identity).
 •	ExamId (FK → Exams).
 •	StudentId (FK → Students).
 •	Score (decimal(5,2), required).
 Relationships
 •	A Student gets one result per Exam.
 */
    }
}
