using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PoC_Backend.Data;
using PoC_Backend.Models;

namespace PoC_Backend.Controllers {

    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase {
        private readonly ICommanderRepo _repository;

        public CommandsController(ICommanderRepo repository) {
            _repository = repository;
        }
        

        //GET api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands() {

            var commandItems = _repository.GetAppCommands();

            return Ok(commandItems);

        }

        // GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id) {

            var commandItem = _repository.GetCommandById(id);
            return Ok(commandItem);

        }

        
    }
}