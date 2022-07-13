using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GamesStoreSEP3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {

        private readonly DataContext _context;
       
        public GameController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<Game>>> GetGames()
        {
            return Ok(await _context.Games.ToListAsync());
           
        }

        [HttpGet ("{id}")]
        public async Task<ActionResult<Game>> GetGameById(int id)
        {
           var game = await _context.Games.FindAsync(id);
            if (game == null)
                return BadRequest("Game not found");
            return Ok(game);
        }

        [HttpPost]
        public async Task<ActionResult<List<Game>>> AddGame(Game game)
        {
            _context.Games.Add(game);
            await _context.SaveChangesAsync();

            return Ok(await _context.Games.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Game>>> UpdateGame(Game request)
        {
            var game = await _context.Games.FindAsync(request.Id);
            if (game == null)
                return BadRequest("Game not found");

            game.Name = request.Name;
            game.Price = request.Price;
            game.Description = request.Description;
            game.Image = request.Image;

            await _context.SaveChangesAsync();

            return Ok(await _context.Games.ToListAsync());      
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Game>>> Delete( int id)
        {
            var game = await _context.Games.FindAsync(id);
            if (game == null)
                return BadRequest("Game not found");

            _context.Games.Remove(game);
            await _context.SaveChangesAsync();

            return Ok(await _context.Games.ToListAsync());

        }
 
    }
}


