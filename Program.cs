using MyVegieStore.Components;
using Microsoft.EntityFrameworkCore;
using MyVegieStore.ViewModel;

using MyVegieStore.Services;


namespace MyVegieStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddScoped<UserIdService>();
            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            // Register MyVegieStoreContext with SQLite
            builder.Services.AddDbContext<MyVegieStoreContext>(options =>
                options.UseSqlite(builder.Configuration.GetConnectionString("MyVegieStoreContext")));

            // Register LoginViewModel as a scoped service
            builder.Services.AddScoped<LoginViewModel>();

            builder.Services.AddScoped<OrderViewModel>();  // Add this line


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
