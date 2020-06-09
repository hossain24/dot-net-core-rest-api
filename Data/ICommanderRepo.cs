using System.Collections;
using System.Collections.Generic;
using DotNetApi.Models;

namespace DotNetApi.Data {
    public interface ICommanderRepo {
        bool SaveChanges ();
        IEnumerable<Command> GetAllCommands ();
        Command GetCommandById (int id);
        void CreateCommand (Command cmd);
        void UpdateCommand (Command cmd);

        void DeleteCommand (Command cmd);

    }
}