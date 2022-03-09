using Core;
using Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAndBooks.BLL.Model
{
    public  class Human
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime Birthday { get; set; }
        public Role Role { get; set; }


        public override bool Equals(object obj)
        {
            return obj is Human human &&
                Id == human.Id &&
                Name == human.Name &&
                Surname == human.Surname &&
                Birthday == human.Birthday &&
                Role == human.Role;
        }
    }
}
