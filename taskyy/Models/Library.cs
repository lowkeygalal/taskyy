using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskyy.Models
{
    internal class Library
    {
        public int LibraryId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public ICollection<Book> NavBook { get; set; }
        /*Represents university libraries.
Columns
•	LibraryId (PK, int, identity).
•	Name (nvarchar(200), required).
•	Location (nvarchar(200), required).
Relationships
•	A Library contains many Books.
*/

    }
}
