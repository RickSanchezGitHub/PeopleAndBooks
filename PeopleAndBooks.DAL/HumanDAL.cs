using PeopleAndBooks.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAndBooks.DAL
{
    public static class HumanDAL
    {
        /// <summary>
        /// 1.2.3
        /// </summary>
        public static List<HumanDto> peoples = new List<HumanDto>()
        {
            new HumanDto()
            {
                Id = 1,
                Name = "Иннокентий",
                Surname = "Пипидастров",
                Patronymic = "Артемович",
                Birthday = new DateTime(2000-12-12),
                Role = Enum.Role.autthor
            },
            new HumanDto()
            {
                Id = 2,
                Name = "Гарри",
                Surname = "Поттер",
                Patronymic = "Артемович",
                Birthday = new DateTime(1966-12-12),
                Role = Enum.Role.autthor
            },
            new HumanDto()
            {
                Id = 3,
                Name = "Александр",
                Surname = "Невредный",
                Patronymic = "Артемович",
                Birthday = new DateTime(1966-06-06),
                Role = Enum.Role.autthor
            },
            new HumanDto()
            {
                Id = 4,
                Name = "Александр",
                Surname = "Невредный",
                Patronymic = "Артемович",
                Birthday = new DateTime(1966-06-06),
                Role = Enum.Role.reader
            },            
            new HumanDto()
            {
                Id = 5,
                Name = "Александр",
                Surname = "Невредный",
                Patronymic = "Артемович",
                Birthday = new DateTime(1966-06-06),
                Role = Enum.Role.reader
            }
        };
    }
}
