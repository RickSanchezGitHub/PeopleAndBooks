using PeopleAndBooks.DAL.Interface;
using PeopleAndBooks.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAndBooks.DAL.Reposotory
{
    public class BookRepository : IBookRepository
    {
        public List<BookDto> GetAll()
        {
            var books = BookDAL.books.Where(b => !b.IsDeleted).ToList();
            return books;
        }

        public List<BookDto> GetByAuthorId(int id)
        {
            var books = BookDAL.books.Where(b => b.AuthorId == id).ToList();
            return books;
        }

        public int Add(BookDto book)
        {
            int lastId = BookDAL.books.Count();
            book.Id = lastId;
            BookDAL.books.Add(book);
            return lastId;
        }

        public void Delete(int id)
        {
            var book = BookDAL.books.FirstOrDefault(b => b.Id == id);
            book.IsDeleted = true;
        }
    }
}
