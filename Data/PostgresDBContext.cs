using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebApplication2MVC.Models;

namespace WebApplication2MVC.Data;

public partial class PostgresDBContext : DbContext
{
    public PostgresDBContext(DbContextOptions<PostgresDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Order> Order { get; set; }

    public virtual DbSet<Site> Site { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Order_pkey");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.Customer).HasMaxLength(20);
            entity.Property(e => e.Revenue).HasPrecision(10, 2);
        });

        modelBuilder.Entity<Site>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Site_pkey");

            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.City).HasMaxLength(20);
            entity.Property(e => e.Leader).HasMaxLength(20);
            entity.Property(e => e.Name).HasMaxLength(20);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
