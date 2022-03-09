using Core;
using Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAndBooks.DAL.Entity
{
    /// <summary>
    /// 1.2.1 - класс пользователя
    /// </summary>
    public class HumanDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime Birthday { get; set; }
        public Role Role { get; set; }
        public bool IsDelete { get; set; }
    }
}
