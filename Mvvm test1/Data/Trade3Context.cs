using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Mvvm_test1;

public partial class Trade3Context : DbContext
{
    public Trade3Context()
    {
    }

    public Trade3Context(DbContextOptions<Trade3Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Ordername> Ordernames { get; set; }

    public virtual DbSet<Orderproduct> Orderproducts { get; set; }

    public virtual DbSet<Pickuppoint> Pickuppoints { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Productcategory> Productcategories { get; set; }

    public virtual DbSet<Productmanufacturer> Productmanufacturers { get; set; }

    public virtual DbSet<Productname> Productnames { get; set; }

    public virtual DbSet<Productprovider> Productproviders { get; set; }

    public virtual DbSet<Producttype> Producttypes { get; set; }

    public virtual DbSet<Productunit> Productunits { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;user=root;password=1234;database=trade3", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.31-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Ordername>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PRIMARY");

            entity.ToTable("ordername");

            entity.HasIndex(e => e.OrderPickupPoint, "FK_IdPickUpPoint_idx");

            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.Fioclient)
                .HasMaxLength(100)
                .HasColumnName("FIOclient");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.OrderDeliveryDate).HasColumnType("datetime");
            entity.Property(e => e.OrderStatus).HasColumnType("text");

            entity.HasOne(d => d.OrderPickupPointNavigation).WithMany(p => p.Ordernames)
                .HasForeignKey(d => d.OrderPickupPoint)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IdPickUpPoint");
        });

        modelBuilder.Entity<Orderproduct>(entity =>
        {
            entity.HasKey(e => new { e.OrderId, e.ProductArticleNumber })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("orderproduct");

            entity.HasIndex(e => e.ProductArticleNumber, "ProductArticleNumber");

            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.ProductArticleNumber)
                .HasMaxLength(100)
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");

            entity.HasOne(d => d.Order).WithMany(p => p.Orderproducts)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("orderproduct_ibfk_1");

            entity.HasOne(d => d.ProductArticleNumberNavigation).WithMany(p => p.Orderproducts)
                .HasForeignKey(d => d.ProductArticleNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("orderproduct_ibfk_2");
        });

        modelBuilder.Entity<Pickuppoint>(entity =>
        {
            entity.HasKey(e => e.IdPickUpPoint).HasName("PRIMARY");

            entity.ToTable("pickuppoint");

            entity.Property(e => e.IdPickUpPoint).ValueGeneratedNever();
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.Street).HasMaxLength(100);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductArticleNumber).HasName("PRIMARY");

            entity.ToTable("product");

            entity.HasIndex(e => e.ProductIdcategory, "FK_ProductIDCategory_idx");

            entity.HasIndex(e => e.ProductIdmanufacturer, "FK_ProductIDManufacturer_idx");

            entity.HasIndex(e => e.ProductIdprovider, "FK_ProductIDProvider_idx");

            entity.HasIndex(e => e.ProductIdunit, "FK_ProductIDUnit_idx");

            entity.HasIndex(e => e.ProductIdname, "FK_ProductName_idx");

            entity.Property(e => e.ProductArticleNumber)
                .HasMaxLength(100)
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.ProductCost).HasPrecision(19, 4);
            entity.Property(e => e.ProductDescription).HasColumnType("text");
            entity.Property(e => e.ProductIdcategory).HasColumnName("ProductIDCategory");
            entity.Property(e => e.ProductIdmanufacturer).HasColumnName("ProductIDManufacturer");
            entity.Property(e => e.ProductIdname).HasColumnName("ProductIDName");
            entity.Property(e => e.ProductIdprovider).HasColumnName("ProductIDProvider");
            entity.Property(e => e.ProductIdunit).HasColumnName("ProductIDUnit");
            entity.Property(e => e.ProductPhoto).HasMaxLength(100);
            entity.Property(e => e.ProductStatus).HasColumnType("text");

            entity.HasOne(d => d.ProductIdcategoryNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.ProductIdcategory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductIDCategory");

            entity.HasOne(d => d.ProductIdmanufacturerNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.ProductIdmanufacturer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductIDManufacturer");

            entity.HasOne(d => d.ProductIdnameNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.ProductIdname)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductName");

            entity.HasOne(d => d.ProductIdproviderNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.ProductIdprovider)
                .HasConstraintName("FK_ProductIDProvider");

            entity.HasOne(d => d.ProductIdunitNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.ProductIdunit)
                .HasConstraintName("FK_ProductIDUnit");
        });

        modelBuilder.Entity<Productcategory>(entity =>
        {
            entity.HasKey(e => e.ProductIdcategory).HasName("PRIMARY");

            entity.ToTable("productcategory");

            entity.Property(e => e.ProductIdcategory)
                .ValueGeneratedNever()
                .HasColumnName("ProductIDCategory");
            entity.Property(e => e.ProductNameCategoryl).HasMaxLength(45);
        });

        modelBuilder.Entity<Productmanufacturer>(entity =>
        {
            entity.HasKey(e => e.ProductIdmanufacturer).HasName("PRIMARY");

            entity.ToTable("productmanufacturer");

            entity.Property(e => e.ProductIdmanufacturer)
                .ValueGeneratedNever()
                .HasColumnName("ProductIDManufacturer");
            entity.Property(e => e.ProductNameManufacturer).HasMaxLength(45);
        });

        modelBuilder.Entity<Productname>(entity =>
        {
            entity.HasKey(e => e.ProductIdname).HasName("PRIMARY");

            entity.ToTable("productname");

            entity.Property(e => e.ProductIdname)
                .ValueGeneratedNever()
                .HasColumnName("ProductIDName");
            entity.Property(e => e.ProductName1)
                .HasMaxLength(45)
                .HasColumnName("ProductName");
        });

        modelBuilder.Entity<Productprovider>(entity =>
        {
            entity.HasKey(e => e.ProductIdprovider).HasName("PRIMARY");

            entity.ToTable("productprovider");

            entity.Property(e => e.ProductIdprovider)
                .ValueGeneratedNever()
                .HasColumnName("ProductIDProvider");
            entity.Property(e => e.ProductNameProvider).HasMaxLength(45);
        });

        modelBuilder.Entity<Producttype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("producttype");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<Productunit>(entity =>
        {
            entity.HasKey(e => e.ProductIdunit).HasName("PRIMARY");

            entity.ToTable("productunit");

            entity.Property(e => e.ProductIdunit)
                .ValueGeneratedNever()
                .HasColumnName("ProductIDUnit");
            entity.Property(e => e.ProductNameUnitl).HasMaxLength(45);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PRIMARY");

            entity.ToTable("role");

            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.RoleName).HasMaxLength(100);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PRIMARY");

            entity.ToTable("user");

            entity.HasIndex(e => e.UserIdrole, "user_ibfk_1");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserIdrole).HasColumnName("UserIDRole");
            entity.Property(e => e.UserLogin).HasColumnType("text");
            entity.Property(e => e.UserName).HasMaxLength(100);
            entity.Property(e => e.UserPassword).HasColumnType("text");
            entity.Property(e => e.UserPatronymic).HasMaxLength(100);
            entity.Property(e => e.UserSurname).HasMaxLength(100);

            entity.HasOne(d => d.UserIdroleNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.UserIdrole)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("user_ibfk_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
