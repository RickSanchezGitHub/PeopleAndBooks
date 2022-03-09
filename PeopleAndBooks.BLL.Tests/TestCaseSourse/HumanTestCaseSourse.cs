using PeopleAndBooks.BLL.Model;
using PeopleAndBooks.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAndBooks.BLL.Tests.TestCaseSourse
{
    public class HumanTestCaseSourse
    {
        public List<HumanDto> GetHumans()
        {
           var humans = 
            new List<HumanDto>()
            {
                new HumanDto()
                {
                    Id = 1,
                    Name = "Иннокентий",
                    Surname = "Пипидастров",
                    Patronymic = "Артемович",
                    Role = Core.Enum.Role.author,
                    Birthday = new DateTime(2000-12-12),
                },
                new HumanDto()
                {
                    Id = 2,
                    Name = "Гарри",
                    Surname = "Поттер",
                    Patronymic = "Артемович",
                    Role = Core.Enum.Role.author,
                    Birthday = new DateTime(1966-12-12),
                },
                new HumanDto()
                {
                    Id = 3,
                    Name = "Александр",
                    Surname = "Невредный",
                    Patronymic = "Артемович",
                    Role = Core.Enum.Role.author,
                    Birthday = new DateTime(1966-06-06),
                }, 
                new HumanDto()
                {
                    Id = 4,
                    Name = "Читатель",
                    Surname = "Вредный",
                    Patronymic = "ТожеАртемович",
                    Role = Core.Enum.Role.reader,
                    Birthday = new DateTime(1966-06-06),
                }
            };
            return humans;
        }
    }
}
