using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DeviceManagement.Models
{
    public partial class MobileContext : DbContext
    {
        public MobileContext()
        {
        }

        public MobileContext(DbContextOptions<MobileContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Laptop> Laptops { get; set; } = null!;
        public virtual DbSet<Mob> Mobs { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=MC1JULY19\\RISHIKA;Database=Mobile;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Laptop>(entity =>
            {
                entity.HasKey(e => e.LapId)
                    .HasName("PK__Laptop__E61AFFB55BFF03AE");

                entity.ToTable("Laptop");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Mob>(entity =>
            {
                entity.ToTable("Mob");

                entity.Property(e => e.Model)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.OrderDetailsId)
                    .HasName("PK__Orders__9DD74DBD655E2BBA");

                entity.Property(e => e.OrderNo).IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Orders_Products");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Orders_Users");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.UserName, "UQ__Users__C9F284566E4CC693")
                    .IsUnique();

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }
        public void DeleteLaptop(int lapId)
        {
            var db = new MobileContext();
            Laptop lap = new Laptop();
            lap = db.Laptops.FirstOrDefault(x => x.LapId == lapId);
            if (lap == null)
                throw new Exception("Not Found");
            db.Remove(lap);
            db.SaveChanges();
        }

        public void DeleteMobile(int mobId)
        {
            var db = new MobileContext();
            Mob mobile = new Mob();
            mobile = db.Mobs.FirstOrDefault(x => x.MobId == mobId);
            if (mobile == null)
                throw new Exception("Not Found");
            db.Remove(mobile);
            db.SaveChanges();

        }

        public List<Laptop> Getlaptop()
        {
            var db = new MobileContext();
            return db.Laptops.ToList();
        }

        public List<Mob> GetMobs()
        {
            var db = new MobileContext();
            return db.Mobs.ToList();
        }

        public void PostLaptop(Laptop lap)
        {
            var db = new MobileContext();
            db.Laptops.Add(lap);
            db.SaveChanges();
        }

        public void PostMobs(Mob mobs)
        {
            var db = new MobileContext();
            db.Mobs.Add(mobs);
            db.SaveChanges();
        }
        public void PostRegistration(User user)
        {
            var db = new MobileContext();
            db.Users.Add(user);
            db.SaveChanges();
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
