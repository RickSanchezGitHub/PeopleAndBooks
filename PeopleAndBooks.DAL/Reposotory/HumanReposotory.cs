using PeopleAndBooks.DAL.Repository.Interface;
using PeopleAndBooks.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAndBooks.DAL.Reposotory
{
    public class HumanReposotory : IHumanReposotory
    {
        public List<HumanDto> GetAll()
        {
            var humans = HumanDAL.humans.Where(h => !h.IsDelete).ToList();
            return humans;
        }

        public List<HumanDto> GetAllAuthor()
        {
            var humans = HumanDAL.humans.Where(h => h.Role == Core.Enum.Role.author && !h.IsDelete).ToList();
            return humans;
        }

        public List<HumanDto> FindHumans(string text)
        {
            var humans = HumanDAL.humans.Where(h => h.Name.StartsWith(text) || h.Name.EndsWith(text) 
                                            || h.Surname.StartsWith(text) || h.Surname.EndsWith(text) ||
                                            h.Patronymic.StartsWith(text) || h.Patronymic.EndsWith(text)).ToList();
            return humans;
        }

        public int Add(HumanDto newHuman)
        {
            var lastId = HumanDAL.humans.Count() + 1;
            newHuman.Id = lastId;
            HumanDAL.humans.Add(newHuman);
            return lastId;
        }
        public void Delete(int id)
        {
            var human = HumanDAL.humans.FirstOrDefault(h => h.Id == id);
            human.IsDelete = true;
        }
    }
}
