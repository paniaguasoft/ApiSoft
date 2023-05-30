using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ApiSoft.Contexto
{
    public class ApplicacionDbContexto: DbContext
    {
        public DbSet<Producto> Producto { get; set; }

    }
}
