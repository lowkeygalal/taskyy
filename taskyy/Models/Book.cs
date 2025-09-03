using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskyy.Models
{
    internal class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int LibraryId { get; set; }
        public Library NavLibrary { get; set; }
        public ICollection<BookLoan> NavBookLoan { get; set; }
        
        /*Represents books available in libraries.
Columns
•	BookId (PK, int, identity).
•	Title (nvarchar(200), required).
•	Author (nvarchar(200), required).
•	ISBN (nvarchar(20), required, unique).
•	LibraryId (FK → Libraries).
Relationships
•	A Book belongs to one Library.
•	A Book can have many BookLoans.
*/
    }
}
