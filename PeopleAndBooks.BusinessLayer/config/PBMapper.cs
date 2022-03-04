using AutoMapper;
using PeopleAndBooks.BLL.Model;
using PeopleAndBooks.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleAndBooks.BLL.config
{
    /// <summary>
    /// Mapper для слоев DAL - BLL
    /// </summary>
    public class PBMapper : Profile
    {
        public PBMapper()
        {
            CreateMap<HumanDto, Human>().ReverseMap();
            CreateMap<BookDto, Book>().ReverseMap();
        }
    }
}
