using AutoMapper;
using FazendaBrasil.AutoMapper;
using FazendaBrasil.Business.ApplicationService;
using FazendaBrasil.Business.ApplicationService.Implementations;
using FazendaBrasil.Business.HyperMedia;
using FazendaBrasil.Persistence;
using FazendaBrasil.Repository;
using FazendaBrasil.Repository.Implementations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using Tapioca.HATEOAS;

namespace FazendaBrasil
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
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projetos C#\FazendaBrasil\FazendaBrasil\FazendaBrasil\DataBaseFile.mdf;Integrated Security=True;Connect Timeout=30"));
            services.AddMvc();

            var filterOptions = new HyperMediaFilterOptions();
            filterOptions.ObjectContentResponseEnricherList.Add(new FrequencyEnricher());
            services.AddSingleton(filterOptions);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new Info
                    {
                        Title = "RESTfull API FAZENDA BRASIL",
                        Version = "v1"
                    });
                c.EnableAnnotations();
            });

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfiles());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IFrequencyApplicationService), typeof(FrequencyApplicationService));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "FazendaBrasilApi V1");
            });

            var option = new RewriteOptions();
            option.AddRedirect("^$", "swagger");
            app.UseRewriter(option);

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "DefaultApi",
                    template: "{controller=Values}/{id?}"
                );
            });
        }
    }
}
