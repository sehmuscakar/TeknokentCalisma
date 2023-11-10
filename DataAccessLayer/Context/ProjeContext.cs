using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Context
{
    public class ProjeContext:DbContext // Dbcontext sınıfı entityframework kütüphanesinin içinde bulunan hazır bir sınıf bunu miras aldık.
    {

        public DbSet<Teknokent> Teknokents { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // override on yazdığınızda sizi karşılayacaktır.
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-PBFD0LU;  database=TeknokentMimari; integrated security=true; TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
