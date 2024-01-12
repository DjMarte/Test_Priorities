using Microsoft.EntityFrameworkCore;
using Test_Priorities.Models;

namespace Test_Priorities.DAL
{
    
    public class Contexto : DbContext
    {
        public DbSet<Prioridades> Prioridades { get; set; }
        public Contexto(DbContextOptions<Contexto> options) : base(options) {
            
        }

    }
}
