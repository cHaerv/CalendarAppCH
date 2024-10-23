using CalendarAppCH.Components;
using Radzen;
using Microsoft.EntityFrameworkCore;
using CalendarAppCH.Data;
using CalendarAppCH.Repositories;
using Microsoft.Extensions.Configuration;

namespace CalendarAppCH
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            // add radzen components to the container.
            builder.Services.AddRadzenComponents();

            // Register repository
            builder.Services.AddScoped<IAppointmentRepository, AppointmentRepository>();

            // allows for dialogues in the frontend to open
            builder.Services.AddScoped<DialogService>();


            // setup the db context using the connection string found in appsetting.Json
            builder.Services.AddDbContext<CalendarDbContext>(options =>
            options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
            



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
