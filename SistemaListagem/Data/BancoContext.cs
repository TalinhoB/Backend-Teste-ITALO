using Microsoft.EntityFrameworkCore;
using SistemaListagem.Models;

namespace SistemaListagem.Data
{
    public class BancoContext: DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) { }
        public DbSet<Usuarios> usuarios { get; set; }
    }
}
