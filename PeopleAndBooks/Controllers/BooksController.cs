using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PeopleAndBooks.API.Model.InputModel;
using PeopleAndBooks.API.Model.OutputModel;
using PeopleAndBooks.BLL.Model;
using PeopleAndBooks.BLL.Service.Interface;

namespace PeopleAndBooks.API.Controllers
{
    /// <summary>
    /// 1.4 - контроллер для книги
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : Controller
    {
        private readonly IBookService _service;
        private readonly IMapper _mapper;

        public BooksController(IBookService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        /// <summary>
        /// 1.4.1.1 метод возвращающий все книги
        /// </summary>
        [HttpGet]
        public ActionResult<List<BookOutputModel>> GetAll()
        {
            var books = _mapper.Map<List<BookOutputModel>>(_service.GetAll());
            return Ok(books);
        }

        /// <summary>
        /// 1.4.1.2 метод возвращающий все книги по id автора
        /// </summary>
        [HttpGet("{id}")]
        public ActionResult<List<BookOutputModel>> GetByAuthorid([FromRoute] int id)
        {
            var books = _mapper.Map<List<BookOutputModel>>(_service.GetBooksByAuthorId(id));
            return Ok(books);
        }

        /// <summary>
        /// 1.4.2 метод добавляющий новую книгу
        /// </summary>
        [HttpPost]
        public ActionResult Add([FromBody] BookInsertInputModel book)
        {
            var id = _service.Add(_mapper.Map <Book>(book));
            return StatusCode(201, id);
        }

        /// <summary>
        /// 1.4.3 метод удаляющий книгу
        /// </summary>
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _service.Delete(id);
            return NoContent();
        }
    }
}
