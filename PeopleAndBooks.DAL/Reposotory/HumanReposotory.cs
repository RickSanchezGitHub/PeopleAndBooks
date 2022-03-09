using PeopleAndBooks.DAL.Repository.Interface;
using PeopleAndBooks.DAL.Entity;
using System;
using Core;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Enum;
using System.Threading.Tasks;
using PeopleAndBooks.Core.Const;

namespace PeopleAndBooks.DAL.Reposotory
{
    public class HumanReposotory : IHumanReposotory
    {
        public List<HumanDto> GetAll()
        {
            var humans = HumanList.humans.Where(h => !h.IsDelete).ToList();
            return humans;
        }

        public List<HumanDto> GetAllAuthor()
        {
            var humans = HumanList.humans.Where(h => h.Role == Role.author && !h.IsDelete).ToList();
            return humans;
        }

        public List<HumanDto> FindHumans(string text)
        {
            var humans = HumanList.humans.Where(h => h.Name.StartsWith(text) || h.Name.EndsWith(text) 
                                            || h.Surname.StartsWith(text) || h.Surname.EndsWith(text) ||
                                            h.Patronymic.StartsWith(text) || h.Patronymic.EndsWith(text)).ToList();
            return humans;
        }

        public int Add(HumanDto newHuman)
        {
            var lastId = HumanList.humans.Count() + ConstRepository.OneIdForAdd;
            newHuman.Id = lastId;
            HumanList.humans.Add(newHuman);
            return lastId;
        }
        public void Delete(int id)
        {
            var human = HumanList.humans.FirstOrDefault(h => h.Id == id);
            human.IsDelete = true;
        }
    }
}
