using PeopleAndBooks.DAL.Entity;
using PeopleAndBooks.DAL.Lists;
using PeopleAndBooks.DAL.Reposotory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAndBooks.DAL.Reposotory
{
    public class LibraryCardRepository : ILibraryCardRepository
    {
        public int Add(LibraryCardDto newLibraryCard)
        {
            var lastId = LibraryCardList.LibraryCards.Count() + 1;
            newLibraryCard.Id = lastId;
            LibraryCardList.LibraryCards.Add(newLibraryCard);
            return lastId;
        }
    }
}
