using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PoC_backend.Models;
using PoC_Backend.Data;

namespace PoC_Backend.Controllers {

    [Route("api/commands/")]
    [ApiController]
    public class CommandsController : ControllerBase {
        private readonly ICommanderRepo _repository;
        //List<TennantData> dataList = new List<TennantData>();

        public CommandsController(ICommanderRepo repository) {
            _repository = repository;
        }
        
        //GET api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Tennant>> GetAllCommands() {

            var commandItems = _repository.GetAppCommands();

            return Ok(commandItems);
        }

        // GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <Tennant> GetCommandById(int id) {

            var commandItem = _repository.getTennantById(id);
            return Ok(commandItem);

        } 

        [Route("login")]
        [HttpGet]
        public ActionResult <User> getLoginInfo(string username, string password) {
            var loginInfo = _repository.getLoginInfo(username, password);
            if(username == "admin" && password == "admin") {
                return Ok("1");
            }
            return Ok("0");
        }

        [Route("data")]
        [HttpGet]
        public ActionResult <List<TennantData>> getTennantData(int moneyUpdate) {
            List<TennantData> moneyInfo = _repository.getMoneyUpdate(moneyUpdate);
          
            return Ok(moneyInfo);
        }
    }


}