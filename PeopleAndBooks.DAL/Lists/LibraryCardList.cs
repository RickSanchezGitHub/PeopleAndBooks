using PeopleAndBooks.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAndBooks.DAL.Lists
{
   /// <summary>
   /// 2.1.3 - пустой статический список карт
   /// </summary>
    public static class LibraryCardList
    {
        public static List<LibraryCardDto> LibraryCards = new List<LibraryCardDto>();
    }
}
