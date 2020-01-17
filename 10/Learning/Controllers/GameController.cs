using System;
using System.Collections.Generic;
using Learning.Models;
using Learning.Repositories;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Learning.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class GameController  : ControllerBase
    {
        private readonly GameRepository _repository = new GameRepository();

        //Get api/games
        [HttpGet]
        public ActionResult<IEnumerable<GameState>> LoadGame()
        {
            return Ok(_repository.Games);
        }

        //Get api/games/42
        [HttpGet("{id}")]
        public ActionResult<GameState> LoadGame(int id)
        {
            var game = _repository.GetGame(id);

            if (game != null)
            {
                return Ok(game);
            }
            return new NotFoundResult();
        }

        // POST api/games
        [HttpPost]
        public CreatedResult NewGame()
        {
            var game = _repository.CreateNewGame();

            return new CreatedResult($"/api/games/{game.Id}", game);
        }

        //Delete api/games/42
        [HttpDelete("{id}")]
        public ActionResult<GameState> Delete(int id)
        {
            bool deleted = _repository.DeleteGame(id);

            if (deleted)
            {
                return new StatusCodeResult(StatusCodes.Status204NoContent);
            }
            return new NotFoundResult();
        }


    }
}
