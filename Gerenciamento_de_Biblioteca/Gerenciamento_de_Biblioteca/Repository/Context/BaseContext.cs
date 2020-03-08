

using Microsoft.EntityFrameworkCore;

namespace Gerenciamento_de_Biblioteca.Context
{
    public class BaseContext : DbContext
    {
        public BaseContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-DB19NV7;Database=biblioteca;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {      

        }

        public BaseContext(DbContextOptions<BaseContext> option)
            :base(option)
        { }
    }
}
