using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using sqlite.Data;
using System.Configuration;
using System.Data;
using System.Windows;

namespace sqlite
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ServiceProvider? serviceProvider;

        protected override void OnStartup(StartupEventArgs e)
        {
            // Configure services
            var services = new ServiceCollection();

            // Add Entity Framework
            services.AddDbContext<ProductContext>(options =>
                options.UseSqlite("Data Source=products.db"));

            // Add MainWindow
            services.AddTransient<MainWindow>();

            serviceProvider = services.BuildServiceProvider();

            // Create and show main window
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
