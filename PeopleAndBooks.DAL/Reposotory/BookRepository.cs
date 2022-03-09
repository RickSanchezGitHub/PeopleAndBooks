using PeopleAndBooks.DAL.Repository.Interface;
using PeopleAndBooks.DAL.Entity;
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
            var books = BookList.books.Where(b => !b.IsDeleted).ToList();
            return books;
        }

        public List<BookDto> GetByAuthorId(int id)
        {
            var books = BookList.books.Where(b => b.AuthorId == id).ToList();
            return books;
        }

        public int Add(BookDto book)
        {
            int lastId = BookList.books.Count() + 1;
            book.Id = lastId;
            BookList.books.Add(book);
            return lastId;
        }

        public void Delete(int id)
        {
            var book = BookList.books.FirstOrDefault(b => b.Id == id);
            book.IsDeleted = true;
        }
    }
}
