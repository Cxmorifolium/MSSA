using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using booksqlite.Models;
using Microsoft.EntityFrameworkCore;

namespace booksqlite.Data
{
    public class BookInventoryContext: DbContext
    {
        public DbSet<Book> Books {  get; set; }
        public DbSet<Genre> Genres { get; set; }
        public BookInventoryContext(DbContextOptions<BookInventoryContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Genres
            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = 1, Name = "Fantasy" },
                new Genre { GenreId = 2, Name = "Horror"},
                new Genre { GenreId = 3, Name = "Science Fiction"},
                new Genre { GenreId = 4, Name = "Mystery"},
                new Genre { GenreId = 5, Name = "Biography"},
                new Genre { GenreId = 6, Name = "Romance" },
                new Genre { GenreId = 7, Name = "Historical Fiction" }
            );

            // Seed Books
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    ISBN = "9780547928227",
                    Title = "The Hobbit",
                    AuthorName = "J.R.R. Tolkien",
                    Description = "A fantasy adventure about Bilbo Baggins",
                    Price = 12.99m,
                    StockQuantity = 25,
                    PublishedDate = new DateTime(1937, 9, 21),
                    GenreId = 1
                },
                new Book
                {
                    ISBN = "9780525478812",
                    Title = "Foundation",
                    AuthorName = "Isaac Asimov",
                    Description = "A science fiction novel about psychohistory",
                    Price = 15.99m,
                    StockQuantity = 18,
                    PublishedDate = new DateTime(1951, 5, 1),
                    GenreId = 3
                },
                new Book
                {
                    ISBN = "9780307887436",
                    Title = "Gone Girl",
                    AuthorName = "Gillian Flynn",
                    Description = "A psychological thriller about a missing wife",
                    Price = 14.99m,
                    StockQuantity = 30,
                    PublishedDate = new DateTime(2012, 6, 5),
                    GenreId = 4
                }
            );

            // Configure relationships
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Genre)
                .WithMany(g => g.Books)
                .HasForeignKey(b => b.GenreId)
                .OnDelete(DeleteBehavior.Restrict); 

            base.OnModelCreating(modelBuilder);
        }

    }
}
