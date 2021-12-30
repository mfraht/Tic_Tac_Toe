using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Tic_Tac_Toe.Models;
using Tic_Tac_Toe.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tic_Tac_Toe.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class GamesController : ControllerBase
    {
        private GameDB _GameDB { get; }

        public GamesController(
            GameDB gameDB
        )
        {
            _GameDB = gameDB;
        }

        // GET api/games
        [HttpGet]
        //public ActionResult<Game> Get() =>
        //        GameDB.Get();
        public string Get()
        {
            return Serialize(_GameDB.Get());
        }

        // POST api/games
        [HttpPost]
        public string Post([FromBody] _gameJson request)
        {
            return Serialize(_GameDB.Get(request.id));
        }

        // POST api/games/start
        [HttpPost("start")]
        public string Start([FromBody] _playerJson request)
        {
            return Serialize(_GameDB.Start(request));
        }

        // POST api/games/move/5
        [HttpPost("move")]
        public bool Post([FromBody] _moveJson moveJson)
        {
            Move m = new Move(moveJson.Player, moveJson.Position);

            return _GameDB.Update(moveJson.id, m);
        }

        private string Serialize(Object o)
        {
            return JsonConvert.SerializeObject(o);
        }

        private Object Deserialize(string s)
        {
            return JsonConvert.DeserializeObject(s);
        }

        public class _gameJson
        {
            public string id { get; set; }
        }

        public class _playerJson
        {
            public string gameId { get; set; }
            public char player { get; set; }
        }

        public class _moveJson
        {
            public string id { get; set; }
            //public Move move { get; set; }
            public char Player { get; set; }
            public int Position { get; set; }
        }
    }
}
