using AutoMapper;
using PeopleAndBooks.BLL.config;
using PeopleAndBooks.BLL.Model;
using PeopleAndBooks.DAL.Interface;
using PeopleAndBooks.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleAndBooks.DAL.Model;
using PeopleAndBooks.BLL.Service.Interface;

namespace PeopleAndBooks.BLL.Service
{
    public class HumanService : IHumanService
    {
        private readonly IMapper _mapper;
        private readonly IHumanReposotory _repository;

        public HumanService(IMapper mapper, IHumanReposotory reposotory)
        {
            _mapper = mapper;
            _repository = reposotory;
        }

        /// <summary>
        /// 1.3.1.1
        /// </summary>
        public List<Human> GetAll()
        {
            var humans = _mapper.Map<List<Human>>(_repository.GetAll());
            return humans;
        }

        public List<Human> GetAllAuthor()
        {
            var humans = _mapper.Map<List<Human>>(_repository.GetAllAuthor());
            return humans;
        }

        public int Add(Human human)
        {
            var entity = _mapper.Map<HumanDto>(human);
            var id = _repository.Add(entity);
            return id;
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<Human> FindHumans(string text)
        {
            var humans = _repository.FindHumans(text);
            return _mapper.Map<List<Human>>(humans);
        }

    }
}
