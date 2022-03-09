using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PeopleAndBooks.API.Model.InputModel;
using PeopleAndBooks.BLL.Model;
using PeopleAndBooks.BLL.Service.Interface;

namespace PeopleAndBooks.API.Controllers
{
    /// <summary>
    /// 2.1.2 - контроллер LibraryCard
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryCardController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ILibraryCardService _service;

        public LibraryCardController(IMapper mapper, ILibraryCardService service)
        {
            _mapper = mapper;
            _service = service;
        }

        /// <summary>
        /// 2.1.4 - Метод добавляющий новую карту
        /// </summary>
        [HttpPost]
        public ActionResult Add(LibraryCardInputModel newLibraryCard)
        {
            var libraryCard = _mapper.Map<LibraryCard>(newLibraryCard);
            var id = _service.Add(libraryCard);
            return StatusCode(StatusCodes.Status201Created, id);
        }
    }
}
