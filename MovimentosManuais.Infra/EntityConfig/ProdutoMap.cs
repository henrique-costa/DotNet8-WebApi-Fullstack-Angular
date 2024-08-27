using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovimentosManuais.ApplicationCore.Entity;

namespace MovimentosManuais.Infra.EntityConfig;

public class ProdutoMap : IEntityTypeConfiguration<Produto>
{
    public void Configure(EntityTypeBuilder<Produto> builder)
    {
        builder.HasKey(x => x.COD_PRODUTO);

        builder.Property(x => x.DES_PRODUTO).HasColumnType("VARCHAR(50)").IsRequired();

        builder.Property(x => x.STA_STATUS).HasColumnType("CHAR(1)").IsRequired();
    }
}
