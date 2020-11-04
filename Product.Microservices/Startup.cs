using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Product.Microservices
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // Added another test comment to see if now, the whole thing works
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDbContext<ProductDbContext>(options =>
            //    options.UseSqlServer(
            //        Configuration.GetConnectionString("ProductConnection"),
            //        b => b.MigrationsAssembly(typeof(ProductDbContext).Assembly.FullName)));

            //services.AddScoped<IProductDbContext>(provider => provider.GetService<ProductDbContext>());
            //services.AddMediatR(Assembly.GetExecutingAssembly());

            //services.AddSwaggerGen(c =>
            //{
            //    c.IncludeXmlComments(string.Format(@"{0}\Product.Microservices.xml", System.AppDomain.CurrentDomain.BaseDirectory));
            //    c.SwaggerDoc("v1", new OpenApiInfo
            //    {
            //        Version = "v1",
            //        Title = "Product.Microservices"
            //    });
            //});

            services.AddControllers();
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

            //app.UseSwagger();

            //app.UseSwaggerUI(c =>
            //{
            //    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Product.Microservices");
            //});

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
