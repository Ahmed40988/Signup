using Microsoft.EntityFrameworkCore;
using WebApplication3.Data; // تأكد من استبدال هذا بالمسار الصحيح لـ DbContext

namespace WebApplication4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<ITIContext>(options =>
                options.UseSqlServer("Server=.;Database=DEPI2;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"));
            // استبدل بسلسلة الاتصال الخاصة بك

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Signup}/{action=Signup}/{id?}"); // تعديل المسار الافتراضي إلى Signup

            app.Run();
        }
    }
}
