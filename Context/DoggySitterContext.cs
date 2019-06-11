using System;
using DoggySitter.Models;
using Microsoft.EntityFrameworkCore;

namespace DoggySitter.Context
{
    public class DoggySitterContext : DbContext
    {
        public DoggySitterContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Branch> Branches { get; set; }
    }
}
