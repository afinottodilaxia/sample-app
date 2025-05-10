namespace SampleWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            ConfigureServices(builder.Services, builder.Configuration);

            var app = builder.Build();

            Configure(app, app.Environment);

            app.Run();
        }

        private static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            // Add services to the container.
            services.AddRazorPages(options =>
            {
                // Configurazione opzioni di routing per Razor Pages
                options.Conventions.AddPageRoute("/Index", "");
                options.Conventions.AddPageRoute("/Index", "home");
            });
        }

        private static void Configure(WebApplication app, IWebHostEnvironment env)
        {
            // Configure the HTTP request pipeline.
            if (!env.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            else
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            // Mappatura delle Razor Pages
            app.MapRazorPages();

            // Endpoint esplicito per la home page
            app.MapGet("/", context => {
                context.Response.Redirect("/Index");
                return Task.CompletedTask;
            });
        }
    }
}
