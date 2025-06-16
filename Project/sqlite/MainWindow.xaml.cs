using Microsoft.EntityFrameworkCore;
using sqlite.Data;
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

namespace sqlite
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        ProductContext context;
        Product selectedProduct;
        Product newProduct = new Product();

        public MainWindow(ProductContext productContext)
        {
            InitializeComponent();
            context = productContext;
            GetProducts();
            AddProductGrid.DataContext = newProduct;
        }

        private void GetProducts()
        {
            ProductDG.ItemsSource = context.Products.ToList();
        }

        private void UpdateProductForEdit(object sender, RoutedEventArgs e)
        {
            selectedProduct = (sender as FrameworkElement).DataContext as Product;
            UpdateProductGrid.DataContext = selectedProduct;
        }

        private void DeleteProduct(object sender, RoutedEventArgs e)
        {
            var product = (sender as FrameworkElement).DataContext as Product;
            if (MessageBox.Show($"Delete '{product.Name}'?", "Confirm", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                context.Products.Remove(product);
                context.SaveChanges();
                GetProducts();
                MessageBox.Show("Product deleted successfully!");
            }
        }

        private void AddProduct(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(newProduct.Name) || newProduct.Price <= 0 || newProduct.StockQuantity < 0)
            {
                MessageBox.Show("Please enter valid product details.");
                return;
            }

            context.Products.Add(new Product
            {
                Name = newProduct.Name,
                Description = newProduct.Description,
                Price = newProduct.Price,
                StockQuantity = newProduct.StockQuantity
            });

            context.SaveChanges();
            GetProducts();

            newProduct = new Product();
            AddProductGrid.DataContext = newProduct;
            MessageBox.Show("Product added successfully!");
        }

        private void UpdateProduct(object sender, RoutedEventArgs e)
        {
            if (selectedProduct?.Id == 0)
            {
                MessageBox.Show("Please select a product to update first.");
                return;
            }

            if (string.IsNullOrWhiteSpace(selectedProduct.Name) || selectedProduct.Price <= 0 || selectedProduct.StockQuantity < 0)
            {
                MessageBox.Show("Please enter valid product details.");
                return;
            }

            var productInDb = context.Products.Find(selectedProduct.Id);
            if (productInDb != null)
            {
                productInDb.Name = selectedProduct.Name;
                productInDb.Description = selectedProduct.Description;
                productInDb.Price = selectedProduct.Price;
                productInDb.StockQuantity = selectedProduct.StockQuantity;

                context.SaveChanges();
                GetProducts();

                selectedProduct = null;
                UpdateProductGrid.DataContext = selectedProduct;
                MessageBox.Show("Product updated successfully!");
            }
        }
    }
}
