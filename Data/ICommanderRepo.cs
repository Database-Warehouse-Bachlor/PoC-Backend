

using System.Collections.Generic;
using PoC_Backend.Models;

namespace PoC_Backend.Data {
    public interface ICommanderRepo {
        IEnumerable<Command> GetAppCommands();

        Command GetCommandById(int id);
        
    }
}