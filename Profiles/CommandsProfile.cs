using AutoMapper;
using DotNetApi.Dtos;
using DotNetApi.Models;

namespace DotNetApi.Profiles {
    public class CommandsProfile : Profile {

        // Source -> Target
        public CommandsProfile () {
            CreateMap<Command, CommandReadDto> ();
            CreateMap<CommandCreateDto, Command> ();
            CreateMap<CommandUpdateDto, Command> ();
            CreateMap<Command, CommandUpdateDto> ();
        }
    }
}