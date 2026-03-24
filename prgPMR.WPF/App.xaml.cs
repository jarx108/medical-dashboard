using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using prgPMR.WPF.Core.Models;
using prgPMR.WPF.Data;
using prgPMR.WPF.Infrastructure.DI;
using prgPMR.WPF.Shell;
using System.Windows;

namespace prgPMR.WPF;

public partial class App : Application
{
    private IHost? _host;

    protected override async void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        _host = Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration(config =>
            {
                config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            })
            .ConfigureServices((context, services) =>
            {
                services.AddPmrServices(context.Configuration);
            })
            .Build();

        await _host.StartAsync();

        // Ensure SQLite database and all tables exist on first run.
        // EnsureCreated() creates tables if they don't exist; it does NOT
        // run migrations — for schema changes, use EF migrations instead.
        using (var scope = _host.Services.CreateScope())
        {
            var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            await db.Database.EnsureCreatedAsync();

            // Seed a default user on very first run (empty database).
            // The user can update their name and password via Update User Info.
            if (!await db.Users.AnyAsync())
            {
                db.Users.Add(new User
                {
                    Username  = "admin",
                    Password  = "admin",
                    Firstname = "Admin",
                    Lastname  = "User"
                });
                await db.SaveChangesAsync();
            }
        }

        // Show Login window first
        var loginWindow = new LoginWindow
        {
            DataContext = _host.Services.GetRequiredService<LoginViewModel>()
        };
        loginWindow.Show();
    }

    protected override async void OnExit(ExitEventArgs e)
    {
        if (_host is not null)
        {
            await _host.StopAsync();
            _host.Dispose();
        }
        base.OnExit(e);
    }

    /// <summary>Resolve any service from anywhere in the app (last resort — prefer constructor injection).</summary>
    public static T GetService<T>() where T : class
        => ((App)Current)._host!.Services.GetRequiredService<T>();
}
