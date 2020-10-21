using System;

using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MarcinKrupnikLab7Zadanie.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public  DbSet<Battery> Batteries { get; set; }
        public  DbSet<Display> Displays{ get; set; }
    }
}
