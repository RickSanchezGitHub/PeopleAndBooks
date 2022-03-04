using PeopleAndBooks.BLL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAndBooks.BLL.Tests.TestCaseSourse
{
    public class HumanTestCaseSourse
    {
        public List<Human> GetHumans()
        {
           var humans = 
            new List<Human>()
            {
                new Human()
                {
                    Id = 1,
                    Name = "Иннокентий",
                    Surname = "Пипидастров",
                    Patronymic = "Артемович",
                    Birthday = new DateTime(2000-12-12)
                },
                new Human()
                {
                    Id = 2,
                    Name = "Гарри",
                    Surname = "Поттер",
                    Patronymic = "Артемович",
                    Birthday = new DateTime(1966-12-12)
                },
                new Human()
                {
                    Id = 3,
                    Name = "Александр",
                    Surname = "Невредный",
                    Patronymic = "Артемович",
                    Birthday = new DateTime(1966-06-06)

                }
            };
            return humans;
        }
    }
}
