using booksqlite.Models;
using booksqlite.Services;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace booksqlite
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly BookService _bookService;
        Book selectedBook;
        Book newBook = new Book();

        public MainWindow(BookService bookService)
        {
            InitializeComponent();
            _bookService = bookService;
            LoadData();
            SetupDataContext();
        }

        private void LoadData()
        {
            BookDG.ItemsSource = _bookService.GetAllBooks();
            LoadGenres();
        }

        private void LoadGenres()
        {
            var genres = _bookService.GetAllGenres();
            AddGenreComboBox.ItemsSource = genres;
            UpdateGenreComboBox.ItemsSource = genres;
        }

        private void SetupDataContext()
        {
            AddBookGrid.DataContext = newBook;
        }

        private void EditBook(object sender, RoutedEventArgs e)
        {
            selectedBook = (sender as FrameworkElement).DataContext as Book;
            UpdateBookGrid.DataContext = selectedBook;
        }

        private void DeleteBook(object sender, RoutedEventArgs e)
        {
            var book = (sender as FrameworkElement).DataContext as Book;
            if (MessageBox.Show($"Delete '{book.Title}'?", "Confirm", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                _bookService.DeleteBook(book.ISBN);
                LoadData();
                MessageBox.Show("Book deleted successfully!");
            }
        }

        private void AddBook(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(newBook.ISBN) || string.IsNullOrWhiteSpace(newBook.Title) ||
                string.IsNullOrWhiteSpace(newBook.AuthorName) || newBook.GenreId == 0)
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            try
            {
                _bookService.AddBook(new Book
                {
                    ISBN = newBook.ISBN,
                    Title = newBook.Title,
                    AuthorName = newBook.AuthorName,
                    Description = newBook.Description,
                    Price = newBook.Price,
                    StockQuantity = newBook.StockQuantity,
                    PublishedDate = newBook.PublishedDate,
                    GenreId = newBook.GenreId
                });

                LoadData();

                // Clear form
                newBook = new Book();
                AddBookGrid.DataContext = newBook;
                MessageBox.Show("Book added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding book: {ex.Message}");
            }
        }

        private void UpdateBook(object sender, RoutedEventArgs e)
        {
            if (selectedBook?.ISBN == null)
            {
                MessageBox.Show("Please select a book to update first.");
                return;
            }

            if (string.IsNullOrWhiteSpace(selectedBook.Title) || string.IsNullOrWhiteSpace(selectedBook.AuthorName) ||
                selectedBook.GenreId == 0)
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            try
            {
                _bookService.UpdateBook(selectedBook);
                LoadData();

                // Clear form
                selectedBook = null;
                UpdateBookGrid.DataContext = selectedBook;
                MessageBox.Show("Book updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating book: {ex.Message}");
            }
        }
    }
}