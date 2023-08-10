using AutoMapper;
using Entities.DataTransferObject;
using Entities.Models;

namespace FilmProjesi.Utilities.AutoMapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<FilmDtoForUpdate, Film>();
            CreateMap<UserDtoForUpdate, User>();
            CreateMap<Film, FilmDto>();
            CreateMap<User, UserDto>();
            CreateMap<FilmDtoForInsertion, Film>();
            CreateMap<UserDtoForInsertion,User>();
        }
    }
}
