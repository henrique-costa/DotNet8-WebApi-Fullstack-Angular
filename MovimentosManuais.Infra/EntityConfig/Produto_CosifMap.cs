using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovimentosManuais.ApplicationCore.Entity;

namespace MovimentosManuais.Infra.EntityConfig;

public class Produto_CosifMap : IEntityTypeConfiguration<Produto_Cosif>
{
    public void Configure(EntityTypeBuilder<Produto_Cosif> builder)
    {
        builder.HasKey(x => new {x.COD_PRODUTO, x.COD_COSIF,});

        builder.Property(x => x.COD_COSIF).HasColumnType("CHAR(11)");

        builder.Property(x => x.COD_CLASSIFICACAO).HasColumnType("CHAR(6)").IsRequired();

        builder.Property(x => x.STA_STATUS).HasColumnType("CHAR(1)").IsRequired();
    }
}
