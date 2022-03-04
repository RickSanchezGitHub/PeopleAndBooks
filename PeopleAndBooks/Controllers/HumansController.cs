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
    /// 1.3
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
        /// 1.3.1.1
        /// </summary>
        [HttpGet]
        public ActionResult<List<HumanOutputModel>> GetAll()
        {
            var humans = _mapper.Map<List<HumanOutputModel>>(_service.GetAll());
            return Ok(humans);
        }

        /// <summary>
        /// 1.3.1.2
        /// </summary>
        [HttpGet]
        public ActionResult<List<HumanOutputModel>> GetAllAuthor()
        {
            var humans = _mapper.Map<List<HumanOutputModel>>(_service.GetAllAuthor());
            return Ok(humans);
        }

        /// <summary>
        /// 1.3.2
        /// </summary>
        [HttpPost]
        public ActionResult Add([FromBody] HumanInsertInputModel human)
        {
            var humanModel = _mapper.Map<Human>(human);
            var id = _service.Add(humanModel);
            return StatusCode(201, id);
        }

        /// <summary>
        /// 1.3.3
        /// </summary>
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _service.Delete(id);
            return NoContent();
        }
    }
}
