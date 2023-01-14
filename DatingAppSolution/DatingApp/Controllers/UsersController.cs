using DatingApp.Data;
using DatingApp.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly DataContext _context;
        public DataContext Context => _context;

        public UsersController(DataContext context) : base()
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        [HttpGet("{"+nameof(id)+"}}")]
        public async Task<ActionResult<AppUser>> GetUserAsync(int id)
        {
            var user = await Context.Users.FindAsync(id);
            if (user is null)
            {
                return NotFound();
            }

            return user;
        } 
    }
}
