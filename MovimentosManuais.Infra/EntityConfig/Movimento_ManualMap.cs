using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovimentosManuais.ApplicationCore.Entity;

namespace MovimentosManuais.Infra.EntityConfig;

public class Movimento_ManualMap : IEntityTypeConfiguration<Movimento_Manual>
{
    public void Configure(EntityTypeBuilder<Movimento_Manual> builder)
    {
        builder.HasKey(x => new {x.DAT_MES, x.DAT_ANO, x.NUM_LANCAMENTO, x.COD_PRODUTO, x.COD_COSIF});

        builder.Property(x => x.DAT_MES).HasColumnType("NUMERIC(2,0)");

        builder.Property(x => x.DAT_ANO).HasColumnType("NUMERIC(4,0)");

        builder.Property(x => x.NUM_LANCAMENTO).HasColumnType("NUMERIC(18,0)");

        builder.Property(x => x.COD_PRODUTO).HasColumnType("CHAR(4)");

        builder.Property(x => x.COD_COSIF).HasColumnType("CHAR(11)");

        builder.Property(x => x.DES_DESCRICAO).HasColumnType("VARCHAR(50)");

        builder.Property(x => x.DAT_MOVIMENTO).HasColumnType("SMALLDATETIME");

        builder.Property(x => x.COD_USUARIO).HasColumnType("VARCHAR(15)");

        builder.Property(x => x.VAL_VALOR).HasColumnType("NUMERIC(18,2)");
    }
}
