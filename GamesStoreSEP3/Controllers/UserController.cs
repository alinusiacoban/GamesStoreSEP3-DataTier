using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamesStoreSEP3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

            private readonly DataContext _context;

            public UserController(DataContext context)
            {
                _context = context;
            }

            [HttpGet]
            public async Task<ActionResult<List<User>>> GetUsers()
            {
                return Ok(await _context.Users.ToListAsync());

            }

            [HttpGet("{id}")]
            public async Task<ActionResult<Game>> GetUserById(int id)
            {
                var user = await _context.Users.FindAsync(id);
                if (user == null)
                    return BadRequest("User not found");
                return Ok(user);
            }

            [HttpPost]
            public async Task<ActionResult<List<User>>> AddUser(User user)
            {
                _context.Users.Add(user);
                await _context.SaveChangesAsync();

                return Ok(await _context.Users.ToListAsync());
            }


            [HttpDelete("{id}")]
            public async Task<ActionResult<List<User>>> Delete(int id)
            {
                var user = await _context.Users.FindAsync(id);
                if (user== null)
                    return BadRequest("User not found");

                _context.Users.Remove(user);
                await _context.SaveChangesAsync();

                return Ok(await _context.Users.ToListAsync());

            }


        }
    }



