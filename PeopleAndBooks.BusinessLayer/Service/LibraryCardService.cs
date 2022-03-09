using AutoMapper;
using PeopleAndBooks.BLL.Model;
using PeopleAndBooks.BLL.Service.Interface;
using PeopleAndBooks.Core.Helpers.HelpersDate;
using PeopleAndBooks.DAL.Entity;
using PeopleAndBooks.DAL.Reposotory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAndBooks.BLL.Service
{
    public class LibraryCardService : ILibraryCardService
    {
        private readonly IMapper _mapper;
        private readonly ILibraryCardRepository _repository;

        public LibraryCardService(IMapper mapper, ILibraryCardRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public int Add(LibraryCard libraryCard)
        {
            var entity = _mapper.Map<LibraryCardDto>(libraryCard);
            entity.DateTimeOffset = HelperDate.FormatDate(libraryCard.DateTimeOffset);
            return _repository.Add(entity);
        }
    }
}
