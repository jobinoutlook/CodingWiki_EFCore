using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<BookDetail> BookDetails { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        public DbSet<Author> Author { get; set; }

        //---------------------------------------
        public DbSet<User> Users { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<Role> Roles { get; set; }
        //---------------------------------------


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=.;Database=CodingWiki;TrustServerCertificate=True;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); //not mandatory here because we inheriting from DbContext

            //------------------------------------------------

            modelBuilder.Entity<Book>()
                .HasOne(bd => bd.BookDetail)
                .WithOne(b => b.Book)
                .HasForeignKey<BookDetail>(bd => bd.BookId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Book>()
                .Property(b => b.Price)
                .HasPrecision(18, 4);

            

            modelBuilder.Entity<Book>().HasData(

                new Book() { BookId = 1, ISBN = "I054485754", Price = (decimal)10.26, Title = "Harry Potter", PublisherId = 1 },
                new Book() { BookId = 2, ISBN = "I954T56565", Price = (decimal)20.26, Title = "Super Mario", PublisherId = 2 },
                new Book() { BookId = 3, ISBN = "I867433467", Price = (decimal)30.26, Title = "He Man", PublisherId = 3 }
                );

            modelBuilder.Entity<BookDetail>().HasData(

                new BookDetail() { BookDetailId = 1, BookId = 1, NumberOfChapters = 10, NumberOfPages = 100, Weight = "100" },
                new BookDetail() { BookDetailId = 2, BookId = 2, NumberOfChapters = 20, NumberOfPages = 200, Weight = "200" },
                new BookDetail() { BookDetailId = 3, BookId = 3, NumberOfChapters = 30, NumberOfPages = 300, Weight = "300" }
                );

            //---------------------------------------------------
            

            modelBuilder.Entity<Publisher>().HasData(
                new Publisher() { PublisherId = 1, Name = "Apress", Location = "NewYork" },
                new Publisher() { PublisherId = 2, Name = "TataMcGrawHill", Location = "Delhi" },
                new Publisher() { PublisherId = 3, Name = "Penguin Books", Location = "London" }
                );

            modelBuilder.Entity<Book>()
                .HasOne(p => p.Publisher)
                .WithMany(b => b.Books)
                .HasForeignKey(p => p.PublisherId)
                .OnDelete(DeleteBehavior.NoAction);
            //---------------------------------------------------

            modelBuilder.Entity<Post>()
                .HasOne(b => b.Blog)
                .WithMany(p => p.Posts)
                .HasForeignKey(b => b.BlogId)
                .OnDelete(DeleteBehavior.Cascade);

            //modelBuilder.Entity<Blog>()
            //    .HasMany(b => b.Posts)
            //    .WithOne(p => p.Blog)
            //    .HasForeignKey(p => p.BlogId)
            //    .OnDelete(DeleteBehavior.Cascade); 



            modelBuilder.Entity<Blog>().HasData(
                new Blog() { BlogId = 1, Title = "Science" },
                new Blog() { BlogId = 2, Title = "Art" },
                new Blog() { BlogId = 3, Title = "Test" }
                );

            modelBuilder.Entity<Post>().HasData(
                new Post() { PostId = 1, BlogId = 1, Content = "Science content" },
                new Post() { PostId = 2, BlogId = 2, Content = "Art content" },
                new Post() { PostId = 3, BlogId = 3, Content = "Test" },
                new Post() { PostId = 4, BlogId = 3, Content = "Test" }
                );

            //----------------------------------------------------
            modelBuilder.Entity<BookAuthorMap>().HasKey(u => new { u.AuthorId, u.BookId });


        }


    }
}
