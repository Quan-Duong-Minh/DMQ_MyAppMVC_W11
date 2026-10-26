using Microsoft.EntityFrameworkCore;
using DMQ_MyAppMVC.Models;

namespace DMQ_MyAppMVC.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}