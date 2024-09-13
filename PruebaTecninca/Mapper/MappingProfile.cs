using AutoMapper;
using PruebaTecninca.DTO;
using PruebaTecninca.Models;

namespace PruebaTecninca.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}
