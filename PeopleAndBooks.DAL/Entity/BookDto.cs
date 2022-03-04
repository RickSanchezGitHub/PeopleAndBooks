using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAndBooks.DAL.Model
{ 
    /// <summary>
    /// 1.2.2
    /// </summary>
    public class BookDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public string Genre { get; set; }
        public bool IsDeleted { get; set; }
    }
}
