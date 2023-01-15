using Microsoft.EntityFrameworkCore;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Context
{
    public class SwitchContext : DbContext
    {
        public SwitchContext(DbContextOptions<SwitchContext> options)
          : base(options)
        { }

        public DbSet<Usuario> Usuarios { get; set; }        

    }
}
