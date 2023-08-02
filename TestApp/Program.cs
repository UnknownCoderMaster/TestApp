using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using TestApp.Data;
using TestApp.Data.Services;

namespace TestApp;

public static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var serviceProvider = new ServiceCollection()
            .AddMemoryCache()
            .AddDbContext<AppDbContext>(options =>
                options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=TestData;Trusted_Connection=True;"))
            .AddScoped<UserService>()
            .AddScoped<ProductService>()
            .BuildServiceProvider();

        var memoryCache = serviceProvider.GetService<IMemoryCache>();
        var userService = serviceProvider.GetService<UserService>();
        var productService = serviceProvider.GetService<ProductService>();

        Application.Run(new Login(userService, memoryCache, productService));
    }
}