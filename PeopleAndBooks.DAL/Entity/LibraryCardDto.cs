using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAndBooks.DAL.Entity
{
    /// <summary>
    /// 2.1.1 - хранение сущности lIbraryCard
    /// </summary>
    public class LibraryCardDto
    {
        public int Id { get; set; }
        public int ReaderId { get; set; }
        public int BookId { get; set; }
        public string DateTimeOffset { get; set; }
        public bool IsDeleted { get; set; }
    }
}
