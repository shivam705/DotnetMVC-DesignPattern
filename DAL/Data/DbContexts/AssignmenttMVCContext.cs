using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DAL.EFModels;

#nullable disable

namespace DAL.Data.DbContexts
{
    public partial class AssignmenttMVCContext : DbContext
    {
        public AssignmenttMVCContext()
        {
        }

        public AssignmenttMVCContext(DbContextOptions<AssignmenttMVCContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Invitaion> Invitaions { get; set; }
        public virtual DbSet<Register> Registers { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("name=DefaultConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("Comment");

                entity.Property(e => e.CommentAdded).IsRequired();
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("Event");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Location).IsRequired();

                entity.Property(e => e.OtherDetails).HasMaxLength(500);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<Invitaion>(entity =>
            {
                entity.HasKey(e => e.InvitationId)
                    .HasName("PK__Invitaio__033C8DCF1AB4C437");

                entity.ToTable("Invitaion");
            });

            modelBuilder.Entity<Register>(entity =>
            {
                entity.ToTable("Register");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.EmailId).IsRequired();

                entity.Property(e => e.Password).IsRequired();

                entity.Property(e => e.UserName).IsRequired();
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Password).IsRequired();

                entity.Property(e => e.UserName).IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
