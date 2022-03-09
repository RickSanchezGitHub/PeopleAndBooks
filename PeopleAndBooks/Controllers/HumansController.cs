using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeopleAndBooks.API.Model.InputModel;
using PeopleAndBooks.API.Model.OutputModel;
using PeopleAndBooks.BLL.Model;
using PeopleAndBooks.BLL.Service.Interface;

namespace PeopleAndBooks.API.Controllers
{
    /// <summary>
    /// 1.3 - контроллер пользователя 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class HumansController : Controller
    {
        private IHumanService _service;
        private IMapper _mapper;

        public HumansController(IHumanService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        /// <summary>
        /// 1.3.1.1 - метод возвращает всех людей
        /// </summary>
        [HttpGet]
        public ActionResult<List<HumanOutputModel>> GetAll()
        {
            var humans = _mapper.Map<List<HumanOutputModel>>(_service.GetAll());
            return Ok(humans);
        }

        /// <summary>
        /// 1.3.1.2 - метод возвращает всех авторов(роль автор)
        /// </summary>
        [HttpGet("authors")]
        public ActionResult<List<HumanOutputModel>> GetAllAuthor()
        {
            var humans = _mapper.Map<List<HumanOutputModel>>(_service.GetAllAuthor());
            return Ok(humans);
        }

        /// <summary>
        /// 1.3.1.3 - метод возвращает по строке запроса лист людей, содержащих строку запроса в имени или фамилии или очесттву
        /// </summary>
        [HttpGet("find")]
        public ActionResult<List<HumanOutputModel>> FindHumans([FromQuery] string text)
        {
            var humans = _mapper.Map<List<HumanOutputModel>>(_service.FindHumans(text));
            return Ok(humans);
        }

        /// <summary>
        /// 1.3.2 - метод добавляющий нового человека с выбором это аватор или читатель
        /// </summary>
        [HttpPost("{Role}")]
        public ActionResult Add(string Role, [FromBody] HumanInsertInputModel human)
        {
            var humanModel = _mapper.Map<Human>(human);
            var id = _service.Add(humanModel);
            return StatusCode(StatusCodes.Status201Created, id);
        }

        /// <summary>
        /// 1.3.3 - метод удаляющий человека
        /// </summary>
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _service.Delete(id);
            return NoContent();
        }

        
    }
}
