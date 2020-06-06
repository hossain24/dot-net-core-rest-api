using AutoMapper;
using DotNetApi.Dtos;
using DotNetApi.Models;

namespace DotNetApi.Profiles {
    public class CommandsProfile : Profile {
        public CommandsProfile () {
            CreateMap<Command, CommandReadDto> ();
        }
    }
}