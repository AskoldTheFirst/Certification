using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class CertificationContext : DbContext
    {
        public CertificationContext(DbContextOptions options) : base (options)
        {
        }

        public DbSet<Question> Questions { get; set; }
    }
}