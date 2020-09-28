using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyApi.data;
using MyApi.Models;

namespace Commander.Controllers {

    [Route ("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase {

        private readonly MockCommanderRepo _repository = new MockCommanderRepo ();

        //GET api/commands
        [HttpGet]

        public ActionResult<IEnumerable<Command>> GetAllCommands () {
            var commandItems = _repository.GetAppCommands ();

            return Ok (commandItems);
        }

        //GET api/commands/{id}
        [HttpGet ("{id}")]
        public ActionResult<Command> GetCommandById (int id) {

            var commandItem = _repository.getCommandById (id);
            return Ok (commandItem);
        }

    }
}