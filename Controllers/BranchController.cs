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
                    Models.Branch.of(1, "Jaffa", "Jerusalem Rd. 29, Jaffa", "8:00-18:00 Everyday"),
                    Models.Branch.of(2, "Bein Nechemia", "Hanarkis 1, Beit Nechemia", "8:00-16:00 Everyday"),
                    Models.Branch.of(3, "Modi'in", "Dekel 11, Modi'in", "8:00-20:00 Everyday"),
                    Models.Branch.of(4, "Hod Hasharon", "Itshak Ben-Tzvi 4, Hod Hasharon", "10:00-19:00 Everyday"),
                   };

                _context.Branches.AddRange(branches);
                _context.SaveChanges();
            }
        }

        public IActionResult Branch()
        {
            ViewData["Title"] = "Our Branches!";

            ViewBag.Branches = _context.Branches.ToList();

            return View();
        }
    }
}
