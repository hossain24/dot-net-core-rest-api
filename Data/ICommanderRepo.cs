using System.Collections;
using System.Collections.Generic;
using DotNetApi.Models;

namespace DotNetApi.Data {
    public interface ICommanderRepo {
        IEnumerable<Command> GetAllCommands ();
        Command GetCommandById (int id);
    }
}