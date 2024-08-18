using MyVegieStore.Components;
using Microsoft.EntityFrameworkCore;
using MyVegieStore.ViewModel;
using MyVegieStore.Services;
using Microsoft.AspNetCore.Components.Authorization;

namespace MyVegieStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Register services
            builder.Services.AddScoped<UserIdService>();

            // Register MyVegieStoreContext with SQLite
            builder.Services.AddDbContext<MyVegieStoreContext>(options =>
                options.UseSqlite(builder.Configuration.GetConnectionString("MyVegieStoreContext")));

            // Register ViewModel services
            builder.Services.AddScoped<LoginViewModel>();
            builder.Services.AddScoped<OrderViewModel>();

            // Register Custom Authentication State Provider
            builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
