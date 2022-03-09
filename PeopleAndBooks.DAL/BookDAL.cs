using PeopleAndBooks.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAndBooks.DAL
{
    /// <summary>
    /// 1.2.3 - статичный класс с книгами
    /// </summary>
    public static class BookDAL
    {
        public static List<BookDto> books = new List<BookDto>()
        {
             new BookDto()
             {
                Id = 1,
                AuthorId = 1,
                Title = "Маленький джун и перый проект",
                Genre = "документальный"
             },
             new BookDto()
             {
                 Id = 2,
                 AuthorId = 1,
                 Title = "Маленький джун и тайный склад вкусняшек",
                 Genre = "документальный"
             },
             new BookDto()
             {
                 Id = 3,
                 AuthorId = 1,
                 Title = "Маленький джун и узник дедлайна",
                 Genre = "документальный"
             },
             new BookDto()
             {
                 Id = 4,
                 AuthorId = 1,
                 Title = "Маленький джун и кубок тимлида",
                 Genre = "документальный"
             },
             new BookDto()
             {
                 Id = 5,
                 AuthorId = 1,
                 Title = "Маленький джун и Орден Синьёров",
                 Genre = "документальный"
             },
             new BookDto()
             {
                 Id = 6,
                 AuthorId = 1,
                 Title = "Маленький джун и Принц корпоратива",
                 Genre = "документальный"
             },
             new BookDto()
             {
                 Id = 7,
                 AuthorId = 1,
                 Title = "Маленький джун и дары смерти",
                 Genre = "документальный"
             },
             new BookDto()
             {
                 Id = 8,
                 AuthorId = 2,
                 Title = "Коддинг и Баггинг",
                 Genre = "классика"
             },
             new BookDto()
             {
                 Id = 9,
                 AuthorId = 2,
                 Title = "Тимлид и джун, как не убить?",
                 Genre = "классика"
             },
             new BookDto()
             {
                 Id = 10,
                 AuthorId = 3,
                 Title = "быть вредным или только казаться?",
                 Genre = "изотерика"
             },
             new BookDto()
             {
                 Id = 11,
                 AuthorId = 3,
                 Title = "как стать вреднейшей версией себя?",
                 Genre = "изотерика"
             }
        };
    }
}
