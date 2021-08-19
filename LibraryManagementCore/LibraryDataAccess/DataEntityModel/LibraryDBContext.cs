using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LibraryDataAccess.DataEntityModel
{
    public partial class LibraryDBContext : DbContext
    {
        public LibraryDBContext()
        {
        }

        public LibraryDBContext(DbContextOptions<LibraryDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<BookAssignments> BookAssignments { get; set; }
        public virtual DbSet<LibraryAssets> LibraryAssets { get; set; }
        public virtual DbSet<Student> Student { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-AKL9PPB\\SQLEXPRESS;Initial Catalog=LibraryDB;User ID=sa;Password=1234;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasIndex(e => e.BookId)
                    .HasName("UQ__Book__3DE0C206CB6BB2DF")
                    .IsUnique();

                entity.Property(e => e.Author).IsUnicode(false);

                entity.Property(e => e.BookId).IsUnicode(false);

                entity.Property(e => e.BookName).IsUnicode(false);
            });

            modelBuilder.Entity<BookAssignments>(entity =>
            {
                entity.HasIndex(e => e.AssignmentId)
                    .HasName("UQ__BookAssi__32499E763C819088")
                    .IsUnique();

                entity.Property(e => e.AssignmentId).IsUnicode(false);

                entity.Property(e => e.BookId).IsUnicode(false);

                entity.Property(e => e.StudentId).IsUnicode(false);

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BookAssignments)
                    .HasPrincipalKey(p => p.BookId)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK__BookAssig__BookI__4316F928");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.BookAssignments)
                    .HasPrincipalKey(p => p.StudentId)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__BookAssig__Stude__4222D4EF");
            });

            modelBuilder.Entity<LibraryAssets>(entity =>
            {
                entity.Property(e => e.BookId).IsUnicode(false);

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.LibraryAssets)
                    .HasPrincipalKey(p => p.BookId)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK__LibraryAs__BookI__3E52440B");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasIndex(e => e.Email)
                    .HasName("UQ__Student__A9D10534D6255CF8")
                    .IsUnique();

                entity.HasIndex(e => e.StudentId)
                    .HasName("UQ__Student__32C52B9809952682")
                    .IsUnique();

                entity.Property(e => e.ClassName).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.HomeAddress).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Phone).IsUnicode(false);

                entity.Property(e => e.StudentId).IsUnicode(false);
            });
        }
    }
}
