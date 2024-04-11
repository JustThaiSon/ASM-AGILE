using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ASM_Agile.DomainClass;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ASM_Agile.Context
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Brands> Brands { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Managers> Managers { get; set; }
        public virtual DbSet<NhaSanXuat> NhaSanXuat { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<PhoneCategories> PhoneCategories { get; set; }
        public virtual DbSet<PhoneCustomers> PhoneCustomers { get; set; }
        public virtual DbSet<PhoneEmployees> PhoneEmployees { get; set; }
        public virtual DbSet<Phones> Phones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-APKREC8K\\SQLEXPRESS;Initial Catalog=Quan_ly_dien_thoaii;Integrated Security=True;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brands>(entity =>
            {
                entity.HasKey(e => e.BrandId)
                    .HasName("PK__Brands__DAD4F3BE79CB6017");

                entity.Property(e => e.BrandId).ValueGeneratedNever();

                entity.Property(e => e.BrandName).IsUnicode(false);
            });

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK__Categori__19093A2B1639EB08");

                entity.Property(e => e.CategoryId).ValueGeneratedNever();

                entity.Property(e => e.CategoryName).IsUnicode(false);
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK__Customer__A4AE64B8EB7C77C4");

                entity.Property(e => e.CustomerId).ValueGeneratedNever();

                entity.Property(e => e.Account).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Gender).IsUnicode(false);

                entity.Property(e => e.Pass).IsUnicode(false);

                entity.Property(e => e.PhoneNumber).IsUnicode(false);
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__Employee__7AD04FF106D659A8");

                entity.Property(e => e.EmployeeId).ValueGeneratedNever();

                entity.Property(e => e.Account).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Gender).IsUnicode(false);

                entity.Property(e => e.Pass).IsUnicode(false);

                entity.Property(e => e.PhoneNumber).IsUnicode(false);

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK__Employees__Manag__2E1BDC42");
            });

            modelBuilder.Entity<Managers>(entity =>
            {
                entity.HasKey(e => e.ManagerId)
                    .HasName("PK__Managers__3BA2AA814057FA6C");

                entity.Property(e => e.ManagerId).ValueGeneratedNever();

                entity.Property(e => e.Account).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.Gender).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.Pass).IsUnicode(false);

                entity.Property(e => e.PhoneNumber).IsUnicode(false);
            });

            modelBuilder.Entity<NhaSanXuat>(entity =>
            {
                entity.Property(e => e.NhaSanXuatId).ValueGeneratedNever();

                entity.Property(e => e.TenNhaSanXuat).IsUnicode(false);
            });

            modelBuilder.Entity<OrderDetails>(entity =>
            {
                entity.HasKey(e => e.OrderDetailId)
                    .HasName("PK__OrderDet__D3B9D30C41232EDE");

                entity.Property(e => e.OrderDetailId).ValueGeneratedNever();

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__OrderDeta__Order__4316F928");

                entity.HasOne(d => d.Phone)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.PhoneId)
                    .HasConstraintName("FK__OrderDeta__Phone__440B1D61");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__Orders__C3905BAF52564A15");

                entity.Property(e => e.OrderId).ValueGeneratedNever();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Orders__Customer__403A8C7D");
            });

            modelBuilder.Entity<PhoneCategories>(entity =>
            {
                entity.HasKey(e => new { e.PhoneId, e.CategoryId })
                    .HasName("PK__PhoneCat__527ED87225D9EF64");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.PhoneCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PhoneCate__Categ__35BCFE0A");

                entity.HasOne(d => d.Phone)
                    .WithMany(p => p.PhoneCategories)
                    .HasForeignKey(d => d.PhoneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PhoneCate__Phone__34C8D9D1");
            });

            modelBuilder.Entity<PhoneCustomers>(entity =>
            {
                entity.HasKey(e => new { e.PhoneId, e.CustomerId })
                    .HasName("PK__PhoneCus__69A4AD9B5DE4D690");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.PhoneCustomers)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PhoneCust__Custo__3D5E1FD2");

                entity.HasOne(d => d.Phone)
                    .WithMany(p => p.PhoneCustomers)
                    .HasForeignKey(d => d.PhoneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PhoneCust__Phone__3C69FB99");
            });

            modelBuilder.Entity<PhoneEmployees>(entity =>
            {
                entity.HasKey(e => new { e.PhoneId, e.EmployeeId })
                    .HasName("PK__PhoneEmp__F4434F2F40F51735");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.PhoneEmployees)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PhoneEmpl__Emplo__398D8EEE");

                entity.HasOne(d => d.Phone)
                    .WithMany(p => p.PhoneEmployees)
                    .HasForeignKey(d => d.PhoneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PhoneEmpl__Phone__38996AB5");
            });

            modelBuilder.Entity<Phones>(entity =>
            {
                entity.HasKey(e => e.PhoneId)
                    .HasName("PK__Phones__F3EE4BD0D284C858");

                entity.Property(e => e.PhoneId).ValueGeneratedNever();

                entity.Property(e => e.Model).IsUnicode(false);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Phones)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK__Phones__BrandID__30F848ED");

                entity.HasOne(d => d.NhaSanXuat)
                    .WithMany(p => p.Phones)
                    .HasForeignKey(d => d.NhaSanXuatId)
                    .HasConstraintName("FK__Phones__NhaSanXu__31EC6D26");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
