using System.Collections.Generic;
using DotNetApi.Models;

namespace DotNetApi.Data {
    public class MockCommanderRepo : ICommanderRepo {
        public IEnumerable<Command> GetAllCommands () {
            var commands = new List<Command> {
                new Command { Id = 1, HowTo = "Go green", Line = "Visit the green hill", Platform = "Hill Track" },
                new Command { Id = 2, HowTo = "Go grey", Line = "Visit the grey hill", Platform = "Hill Track" },
                new Command { Id = 3, HowTo = "Go red", Line = "Visit the red hill", Platform = "Hill Track" }
            };

            return commands;
        }

        public Command GetCommandById (int id) {
            return new Command { Id = 01, HowTo = "Go green", Line = "Visit the hill", Platform = "Hill Track" };
        }
    }
}