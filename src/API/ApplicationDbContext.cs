using System.Reflection.Emit;
using API.Domain;
using Microsoft.EntityFrameworkCore;

namespace API
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {
            
        }

        public DbSet<Jogo> Jogos { get; set; }
    }
}