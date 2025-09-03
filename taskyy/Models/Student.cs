using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskyy.Models
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        public DateOnly BirthDate { get; set; }
        public string Address { get; set; }
        public int DepartmentId { get; set; }
        public Department NavDepartmentId { get; set; }
        public ICollection<Enrollment> NavEnrollment { get; set; }
        public ICollection<ExamResult> NavExamResult { get; set; }
        public ICollection<Submission> NavSubmission { get; set; }
        public ICollection<BookLoan> NavBookLoan { get; set; }
        /*Columns
 •	StudentId (PK, int, identity) - Unique identifier.
 •	FullName (nvarchar(200), required).
 •	Email (nvarchar(150), required, unique).
 •	Phone (nvarchar(20), optional).
 •	BirthDate (date, required).
 •	Address (nvarchar(300), optional).
 •	DepartmentId (FK → Departments).
 Relationships
 •	Each student belongs to one Department.
 •	Students can enroll in many Courses via Enrollments.
 •	Students can submit Assignments and take Exams.
 •	Students can borrow Books via BookLoans.
 */




    }
}
