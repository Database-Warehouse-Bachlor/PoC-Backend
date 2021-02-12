

using System.Collections.Generic;
using PoC_Backend.Models;

namespace PoC_Backend.Data {
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command> {
                new Command{Id = 0, howTo = "Boil an egg", platform = "Egg boil"},
                new Command{Id = 1, howTo = "Cut egg", platform = "knife"},
                new Command{Id = 2, howTo = "Bread an egg", platform = "Tea and coffe"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id = 0, howTo = "Boil an egg", platform = "Egg boil"};
        }
    }
}