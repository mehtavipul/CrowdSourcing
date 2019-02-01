using Microsoft.AspNetCore.Mvc;
using SE.Catalog.Contracts;
using SE.Catalog.Models;
using System.Linq;
using System.Threading.Tasks;

namespace SE.Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public readonly IRepositoryBase<User> _userRepo;

        public UsersController(IRepositoryBase<User> context)
        {
            _userRepo = context;
        }

        // GET: api/Users
        [HttpGet]
        public IQueryable<User> GetUser()
        {
            var criteria = new PageNSort
            {
                Sort = "Name",
                SortOrder = SortOrder.Desc,
                PageNumber = 1,
                PageSize = 2
            };

            return _userRepo.Search(criteria);
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = await _userRepo.FirstOrDefaultAsync(x => x.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        // PUT: api/Users/5
        [HttpPut("{id}")]
        public IActionResult PutUser([FromRoute] int id, [FromBody] User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != user.Id)
            {
                return BadRequest();
            }
            _userRepo.Update(user);

            return NoContent();
        }

        // POST: api/Users
        [HttpPost]
        public async Task<IActionResult> PostUser([FromBody] User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _userRepo.Add(user);
            await _userRepo.SaveAsync();

            return CreatedAtAction("GetUser", new { id = user.Id }, user);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = await _userRepo.FirstOrDefaultAsync(x => x.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            _userRepo.Delete(user);

            return Ok(user);
        }

        private bool UserExists(int id)
        {
            return _userRepo.Any(e => e.Id == id);
        }
    }
}