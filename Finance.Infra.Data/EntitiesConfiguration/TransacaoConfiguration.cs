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
    internal class TransacaoConfiguration : IEntityTypeConfiguration<Transacao>
    {
        public void Configure(EntityTypeBuilder<Transacao> builder)
        {

            builder.HasKey(t => t.Id);
            builder.Property(t => t.Descricao).HasMaxLength(250).IsRequired();
            builder.Property(t => t.DescricaoPlanoConta);
            builder.Property(t => t.Tipo);
            builder.Property(t => t.DataFinal);
            builder.Property(t => t.Conta_Id);
            builder.Property(t => t.Data);
            builder.Property(t => t.NomeConta);
            builder.Property(t => t.Plano_Contas_Id);
            builder.Property(t => t.Valor);
            
        }
    }
}
