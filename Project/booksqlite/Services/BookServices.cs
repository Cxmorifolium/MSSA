using booksqlite.Data;
using booksqlite.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booksqlite.Services
{
    public class BookService
    {
        private readonly BookInventoryContext _context;

        public BookService(BookInventoryContext context)
        {
            _context = context;
        }

        public List<Book> GetAllBooks()
        {
            return _context.Books.Include(b => b.Genre).ToList();
        }

        public List<Genre> GetAllGenres()
        {
            return _context.Genres.ToList();
        }

        public void AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void UpdateBook(Book book)
        {
            var existingBook = _context.Books.Find(book.ISBN);
            if (existingBook != null)
            {
                existingBook.Title = book.Title;
                existingBook.AuthorName = book.AuthorName;
                existingBook.Description = book.Description;
                existingBook.Price = book.Price;
                existingBook.StockQuantity = book.StockQuantity;
                existingBook.PublishedDate = book.PublishedDate;
                existingBook.GenreId = book.GenreId;
                _context.SaveChanges();
            }
        }

        public void DeleteBook(string isbn)
        {
            var book = _context.Books.Find(isbn);
            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
        }

        public Book? GetBookByISBN(string isbn)
        {
            return _context.Books.Include(b => b.Genre).FirstOrDefault(b => b.ISBN == isbn);
        }
    }
}
