using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        //api/users/
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUSers()
        {
            return await _context.Users.ToListAsync();
        }

        [HttpGet("{id}")]
        //api/users/2
        public async Task<ActionResult<AppUser>> GetUSer(int id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}