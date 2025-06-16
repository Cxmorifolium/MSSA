using booksqlite.Data;
using booksqlite.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Data;
using System.Windows;

namespace booksqlite
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ServiceProvider? serviceProvider;

        protected override void OnStartup(StartupEventArgs e)
        {
            var services = new ServiceCollection();

            // Add Entity Framework
            services.AddDbContext<BookInventoryContext>(options =>
                options.UseSqlite("Data Source=bookinventory.db"));

            // Add Services
            services.AddScoped<BookService>();
            services.AddTransient<MainWindow>();

            serviceProvider = services.BuildServiceProvider();

            var mainWindow = serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();

            base.OnStartup(e);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            serviceProvider?.Dispose();
            base.OnExit(e);
        }
    }

}
