using Microsoft.EntityFrameworkCore;
using PruebaTecninca.Models;

namespace PruebaTecninca.Data
{
    public class ContextDB : DbContext
    {
        public ContextDB(DbContextOptions<ContextDB> options) : base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
    }
}
