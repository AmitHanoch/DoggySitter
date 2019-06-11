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
    public class BranchController : Controller
    {
        public IActionResult Branch()
        {
            ViewData["Message"] = "dsadad";

            return View();
        }

    }
}
