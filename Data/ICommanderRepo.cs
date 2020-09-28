using System.Collections.Generic;
using MyApi.Models;

namespace MyApi.data {
    public interface ICommanderRepo {
        IEnumerable<Command> GetAppCommands ();
        Command getCommandById(int id);
    }
}