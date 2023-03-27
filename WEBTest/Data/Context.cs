using Microsoft.EntityFrameworkCore;
using WEBTest.Models;

namespace WEBTest.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context>options):base(options) { }

        public DbSet<Conteiner>? conteiners { get; set; }
        public DbSet<Movimentações>? movimenta { get; set; }
    }
}
