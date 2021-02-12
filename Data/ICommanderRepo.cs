

using System.Collections.Generic;
using PoC_backend.Models;

namespace PoC_Backend.Data {
    public interface ICommanderRepo {
        IEnumerable<Tennant> GetAppCommands();

        Tennant getTennantById (int id);

        User getLoginInfo(string username, string password);
    }
}