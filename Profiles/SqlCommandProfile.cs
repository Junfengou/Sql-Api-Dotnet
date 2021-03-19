using AutoMapper;
using SpicyWebApi.Dtos;
using SpicyWebApi.Models;

namespace SpicyWebApi.Profiles
{
    public class SqlCommandProfile : Profile
    {
        public SqlCommandProfile()
        {
            // In order to perform any sort of mapping, this folder and maps must be specified!!

            CreateMap<SqlCommands, SqlReadDto>();// get
            CreateMap<SqlCreateDto, SqlCommands>();// post
            CreateMap<SqlUpdateDto, SqlCommands>(); // update
            CreateMap<SqlCommands, SqlUpdateDto>(); // patch
        }
    }
}