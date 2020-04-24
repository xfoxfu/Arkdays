using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Noha.Arkdays.Models;
using Noha.Arkdays.Services;
using Microsoft.AspNetCore.Http;

namespace Noha.Arkdays
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddDbContext<ArkdaysContext>();

            services.AddTableHolder<Torappu.CharacterDB>(Path.Combine(Environment.CurrentDirectory, "..", "Data", "_tables", "character_table.json"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // app.UseHttpsRedirection();

            app.UseRouting();

            // app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();


                endpoints
                    .Map("/{**Path}",
                new ApplicationBuilder(app.ApplicationServices)
                        .Use(next => context =>
                        {
                            context.SetEndpoint(null);

                            return next(context);
                        })
                        .UseStaticFiles(new StaticFileOptions
                        {
                            FileProvider = new PhysicalFileProvider(
                                Path.Combine(Directory.GetCurrentDirectory(), "..", "Data")),
                            ServeUnknownFileTypes = true,
                        }).Build())
                        .RequireHost(Constants.FileServer);

                endpoints.MapFallback(async ctx =>
                {
                    ctx.Response.StatusCode = 404;
                    await ctx.Response.Body.WriteAsync(
                        System.Text.Encoding.ASCII.GetBytes(
                            "{\"statusCode\":404,\"error\":\"Not Found\",\"message\":\"API endpoint not found\"}"));
                });
            });
        }
    }
}
