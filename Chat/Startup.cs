using Chat.Models;
using Chat.Service.ChatService;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
namespace Chat
{
    public class Startup
    {
        public IConfiguration configRoot
        {
            get;
        }
        public Startup(IConfiguration configuration)
        {
            configRoot = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddTransient<IChatService, ChatService>();
            string connection = configRoot.GetConnectionString("DefaultConnection");
            services.AddDbContext<ChatContext>(options =>
                options.UseSqlServer(connection));
        }


        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.MapRazorPages();
            app.Run();
        }
    }
}
