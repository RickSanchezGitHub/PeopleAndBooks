using PeopleAndBooks.DAL.Interface;
using PeopleAndBooks.DAL.Model;
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
            var humans = HumanDAL.peoples.Where(h => !h.IsDelete).ToList();
            return humans;
        }

        public List<HumanDto> GetAllAuthor()
        {
            var humans = HumanDAL.peoples.Where(h => h.Role == Enum.Role.autthor && !h.IsDelete).ToList();
            return humans;
        }

        public void FindHuman()
        {
            // поиска людей по ключевому слову имени/фамилии/очеству
        }
        public int Add(HumanDto newHuman)
        {
            var lastId = HumanDAL.peoples.Count();
            newHuman.Id = lastId;
            HumanDAL.peoples.Add(newHuman);
            return lastId;
        }
        public void Delete(int id)
        {
            var human = HumanDAL.peoples.FirstOrDefault(h => h.Id == id);
            human.IsDelete = true;
        }
    }
}
