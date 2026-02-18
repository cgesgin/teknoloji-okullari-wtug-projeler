using _04Dtos.Dtos;
using _04Dtos.Models;
using AutoMapper;

namespace _04Dtos.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>();
        }
    }
}
