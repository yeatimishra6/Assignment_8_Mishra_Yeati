using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Assignment_8_Mishra_Yeati.Models;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore.Migrations;
using Assignment_8_Mishra_Yeati.Data;

namespace Assignment_8_Mishra_Yeati
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerDocument();

            services.AddDbContext<FinalProjectData>(options => options.UseSqlServer(Configuration.GetConnectionString("FinalProjectData")));
            services.AddScoped<IFinalProjectDataDAO, FinalProjectContextDAO>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, FinalProjectData context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }
            app.UseOpenApi();
            app.UseSwaggerUi3();
           context.Database.Migrate();

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}