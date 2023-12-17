using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Labo4.Models;

public partial class BdgplccContext : DbContext
{
    public BdgplccContext()
    {
    }

    public BdgplccContext(DbContextOptions<BdgplccContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Livre> Livres { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=bdgplcc");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Livre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Livres__3214EC076954E5D7");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Categorie).HasMaxLength(255);
            entity.Property(e => e.Titre).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
