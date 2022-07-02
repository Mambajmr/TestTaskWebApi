using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using TestTaskWebApi.Data;
using Newtonsoft.Json.Serialization;

namespace TestTaskWebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public Type Iproduct { get; private set; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ProductContext>(opts => {
                opts.UseSqlServer(
                    Configuration["ConnectionStrings:ProductConnection"]); // добавление сервиса для использования баз данных
            });

            services.AddControllers(); //сервис контроллера для его использования

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies()); //регистрируем автомаппер как сервис для его использования

            services.AddScoped<IProduct, SqlProductRepo>();// использование сервиса для внедрения зависимостей.
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

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
