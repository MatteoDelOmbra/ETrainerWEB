using System.Linq;
using System.Text.Json.Serialization;
using ETrainerWEB.Data;
using ETrainerWEB.Models;
using ETrainerWEB.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;


namespace ETrainerWEB
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
            services.AddDbContext<ETrainerDbContext>(options => options.UseMySQL(Configuration.GetConnectionString("Default")));
            services.AddSingleton<AutomapperService>();
            services.AddScoped<PropertyCopierService<Workout>>();
            services.AddScoped<PropertyCopierService<Exercise>>();
            services.AddScoped<PropertyCopierService<ExerciseType>>();
            services.AddScoped<PropertyCopierService<ExerciseSchema>>();
            services.AddScoped<PropertyCopierService<WorkoutSchema>>();
            services.AddScoped<PropertyCopierService<User>>();
            services.AddScoped<PropertyCopierService<Measurement>>();
            services.AddScoped<WorkoutService>();
            services.AddScoped<ExerciseService>();
            services.AddScoped<ExerciseTypeService>();
            services.AddScoped<ExerciseSchemaService>();
            services.AddScoped<WorkoutSchemaService>();
            services.AddScoped<UserService>();
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ETrainerDbContext>();
            services.AddControllers().AddJsonOptions(options => options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "E_Trainer_WEB", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "E_Trainer_WEB v1"));
            }

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
