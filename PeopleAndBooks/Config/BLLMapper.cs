using AutoMapper;
using PeopleAndBooks.API.Model.InputModel;
using PeopleAndBooks.API.Model.OutputModel;
using PeopleAndBooks.BLL.Model;

namespace PeopleAndBooks.API.Config
{
    public class BLLMapper : Profile
    {
        public BLLMapper()
        {
            CreateMap<HumanOutputModel, Human>().ReverseMap();
            CreateMap<HumanInsertInputModel, Human>().ReverseMap();

            CreateMap<BookOutputModel, Book>().ReverseMap();
            CreateMap<BookInsertInputModel, Book>().ReverseMap();
        }
    }
}
