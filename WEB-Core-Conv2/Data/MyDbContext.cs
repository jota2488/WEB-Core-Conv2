using Microsoft.EntityFrameworkCore;
using WEB_Core_Conv2.Models;

namespace WEB_Core_Conv2.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        public DbSet<Paciente> Paciente { get; set; }
    }
}
