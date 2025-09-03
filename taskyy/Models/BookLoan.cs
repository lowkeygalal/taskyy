using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskyy.Models
{
    internal class BookLoan
    {
        public int LoanId { get; set; } 
        public int BookId { get; set; }
        public Book NavBook { get; set; }
        public int StudentId { get; set; }
        public Student NavStudent { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        /*Represents book borrowings by students.
Columns
•	LoanId (PK, int, identity).
•	BookId (FK → Books).
•	StudentId (FK → Students).
•	LoanDate (datetime, required).
•	ReturnDate (datetime, optional).
Relationships
•	A Student can borrow many Books.
•	A Book can be loaned multiple times.
*/


    }
}
