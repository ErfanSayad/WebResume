using Resume.Application;
using Resume.Application.Services.Implementation;
using Resume.Application.Services.Interface;
using Resume.Domain.Entities;
using Resume.Domain.RepositoryInterface;
using Resume.infrastructure;
using Resume.infrastructure.Repository;
using Resume.Infrastructure.ResumeDbContext;

namespace Resume.Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<ResumeDbContext>();


            #region Repositories

            builder.Services.AddScoped<IEducationRepository, EducationRepository>();
            builder.Services.AddScoped<IExperienceRepository, ExperienceRepository>();
            builder.Services.AddScoped<IMySkillsRepository, MySkillsRepository>();
            builder.Services.AddScoped<IContactUsRepository, ContactUsRepository>();
            #endregion

            #region Services

            builder.Services.AddScoped<IContactUsService, ContactUsService>();
            builder.Services.AddScoped<IDashbordService, DashbordService>();
            builder.Services.AddScoped<IEducationService, EducationService>();
            builder.Services.AddScoped<IExperienceService, ExperienceService>();
            builder.Services.AddScoped<IMySkillService, MySkillService>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

            #endregion

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "areas",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");


            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");


            app.Run();
        }
    }
}
