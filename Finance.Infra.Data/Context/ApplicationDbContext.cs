using Finance.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Finance.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        public DbSet<Conta> Contas { get; set; }
        public DbSet<PlanoConta> PlanosContas { get; set; }
        public DbSet<Transacao> Transacoes { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }

    }
}
