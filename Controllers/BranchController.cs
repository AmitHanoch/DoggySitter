using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoggySitter.Context;
using DoggySitter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DoggySitter.Controllers
{
    public class BranchController : Controller
    {
        private readonly DoggySitterContext _context;

        public BranchController(DoggySitterContext context)
        {
            _context = context;
        }

        public IActionResult Branch()
        {
            ViewData["Message"] = "dsadad";

            return View();
        }

        public string GetBranches()
        {
            List<Branch> branches = _context.Branches.ToList();

            return JsonConvert.SerializeObject(branches, Formatting.Indented);
        }

    }
}
