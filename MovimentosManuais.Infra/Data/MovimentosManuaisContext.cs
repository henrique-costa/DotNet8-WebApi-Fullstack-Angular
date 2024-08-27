using System;
using Microsoft.EntityFrameworkCore;
using MovimentosManuais.ApplicationCore.Entity;
using MovimentosManuais.Infra.EntityConfig;

namespace MovimentosManuais.Infra.Data;

public class MovimentosManuaisContext : DbContext
{
    public MovimentosManuaisContext(DbContextOptions<MovimentosManuaisContext> options) : base(options)
    {
        
    }

    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Produto_Cosif> Produto_Cosifs { get; set; }
    public DbSet<Movimento_Manual> MovimentosManuais { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Produto>().ToTable("PRODUTO");
        builder.Entity<Produto>().ToTable("PRODUTO");
        builder.Entity<Produto>().ToTable("PRODUTO");

        builder.ApplyConfiguration(new Movimento_ManualMap());
    }
}
