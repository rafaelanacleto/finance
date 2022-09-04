using Finance.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Infra.Data.EntitiesConfiguration
{
    public class PlanoContasConfiguration : IEntityTypeConfiguration<PlanoConta>
    {
        public void Configure(EntityTypeBuilder<PlanoConta> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Descricao).HasMaxLength(250).IsRequired();
            builder.Property(p => p.Tipo).HasMaxLength(100).IsRequired();

            builder.HasData(
             new PlanoConta(1, "Teste")
           );
            
        }
    }
}
