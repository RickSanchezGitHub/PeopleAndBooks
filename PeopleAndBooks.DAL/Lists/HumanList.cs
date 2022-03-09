using Core.Enum;
using PeopleAndBooks.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAndBooks.DAL
{
    public static class HumanList
    {
        /// <summary>
        /// 1.2.3 - статичный класс с пользователями
        /// </summary>
        public static List<HumanDto> humans = new List<HumanDto>()
        {
            new HumanDto()
            {
                Id = 1,
                Name = "Иннокентий",
                Surname = "Пипидастров",
                Patronymic = "Артемович",
                Birthday = new DateTime(2000-12-12),
                Role = Role.author
            },
            new HumanDto()
            {
                Id = 2,
                Name = "Гарри",
                Surname = "Поттер",
                Patronymic = "Артемович",
                Birthday = new DateTime(1966-12-12),
                Role = Role.author
            },
            new HumanDto()
            {
                Id = 3,
                Name = "Александр",
                Surname = "Невредный",
                Patronymic = "Михайлович",
                Birthday = new DateTime(1966-06-06),
                Role = Role.author
            },
            new HumanDto()
            {
                Id = 4,
                Name = "Александр",
                Surname = "Невредный",
                Patronymic = "Васильевич",
                Birthday = new DateTime(1966-06-06),
                Role = Role.reader
            },            
            new HumanDto()
            {
                Id = 5,
                Name = "Александр",
                Surname = "Невредный",
                Patronymic = "Артемович",
                Birthday = new DateTime(1966-06-06),
                Role = Role.reader
            }
        };
    }
}
