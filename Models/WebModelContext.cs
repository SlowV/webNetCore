using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebNetCore.Models
{
    public class WebModelContext : DbContext
    {
        public WebModelContext(DbContextOptions<WebModelContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
