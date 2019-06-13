using System;
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

            createBranchesData();
        }

        private void createBranchesData()
        {
            if (!_context.Branches.ToList().Any())
            {
                List<Branch> branches = new List<Branch>
                {
                    new Branch(1, "Jaffa", "Jerusalem Rd. 29, Jaffa", "8:00-18:00 Everyday"),
                    new Branch(2, "Bein Nechemia", "Hanarkis 1, Beit Nechemia", "8:00-16:00 Everyday"),
                };

                _context.Branches.AddRange(branches);
                _context.SaveChanges();
            }
        }

        public IActionResult Branch()
        {
            ViewData["Title"] = "Our Branches!";

            return View();
        }

        [HttpGet]
        public JsonResult GetBranches()
        {
            List<Branch> branches = _context.Branches.ToList();

            return Json(branches);
        }

    }
}
