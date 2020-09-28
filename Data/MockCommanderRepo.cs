using System.Collections.Generic;
using MyApi.Models;

namespace MyApi.data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command{id=0, HowTo="Boil Egg", Line="Boil water", Platform="kettle and pan"},
                new Command{id=1, HowTo="make pizza", Line="pepperonies", Platform="pan"},
                new Command{id=2, HowTo="make a sandwich", Line="ham", Platform="paper plate"}
            };
            return commands;
        }

        public Command getCommandById(int id)
        {
            return new Command{id=0, HowTo="Boil Egg", Line="Boil water", Platform="kettle and pan"};
        }
    }

}