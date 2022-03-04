using AutoMapper;
using PeopleAndBooks.BLL.Model;
using PeopleAndBooks.BLL.Service.Interface;
using PeopleAndBooks.DAL.Interface;
using PeopleAndBooks.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAndBooks.BLL.Service
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _repository;
        private readonly IMapper _mapper;

        public BookService(IBookRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<Book> GetAll()
        {
            var books = _mapper.Map<List<Book>>(_repository.GetAll());
            return books;
        }

        public List<Book> GetBooksByAuthorId(int id)
        {
            var books = _mapper.Map<List<Book>>(_repository.GetByAuthorId(id));
            return books;
        }

        public int Add(Book book)
        {
            var id = _repository.Add(_mapper.Map<BookDto>(book));
            return id;
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
