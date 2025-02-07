﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace test2.Models;

public partial class ESQtempdatabasedbContext : DbContext
{
    public ESQtempdatabasedbContext()
    {
    }

    public ESQtempdatabasedbContext(DbContextOptions<ESQtempdatabasedbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Category { get; set; }

    public virtual DbSet<ChildCategory> ChildCategory { get; set; }

    public virtual DbSet<Record> Record { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=E:\\SQ\\temp\\database.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.Property(e => e.CategoryName).IsRequired();
        });

        modelBuilder.Entity<ChildCategory>(entity =>
        {
            entity.Property(e => e.ChildCategoryName).IsRequired();

            entity.HasOne(d => d.Category).WithMany(p => p.ChildCategory)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Record>(entity =>
        {
            entity.Property(e => e.DeliveryDate).IsRequired();
            entity.Property(e => e.MaterialNo).IsRequired();
            entity.Property(e => e.Model).IsRequired();
            entity.Property(e => e.Price)
                .IsRequired()
                .HasColumnType("NUMERIC");
            entity.Property(e => e.Quantity).IsRequired();
            entity.Property(e => e.Vendor).IsRequired();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}