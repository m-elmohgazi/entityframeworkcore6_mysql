using Microsoft.EntityFrameworkCore;
using Models;

namespace DataAccess
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext()
        {
            
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author>Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=entityframeworkcore6_mysql;user=root;password=123456");
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<Author>(entity =>
        //    {
        //        entity.HasKey(e => e.AuthorId);
        //        entity.Property(e => e.FirstName).IsRequired();
        //        entity.HasOne(d => d.)
        //          .WithMany(p => p.Books);
        //    });

        //    modelBuilder.Entity<Book>(entity =>
        //    {
        //        entity.HasKey(e => e.BookId);
        //        entity.Property(e => e.Title).IsRequired();
                
        //    });
        //}
    }
}