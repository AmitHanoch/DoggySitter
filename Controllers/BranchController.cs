using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoggySitter.Context;
using DoggySitter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DoggySitter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly DoggySitterContext _context;

        public BranchController(DoggySitterContext context)
        {
            _context = context;

            if (_context.Branches.Count() == 0)
            {
                _context.Branches.Add(new Branch(1, "olam"));
                _context.SaveChanges();
            }
        }

        // GET: api/Todo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Branch>>> GetTodoItems()
        {
            return await _context.Branches.ToListAsync();
        }

        // GET: api/Todo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Branch>> GetTodoItem(long id)
        {
            var todoItem = await _context.Branches.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }
    }
}
