using System.Reflection;
using WebApiF1.Database;
using WebApiF1.Services;

namespace WebApiF1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddTransient<IMyOperationTransient, GuidService>();
            builder.Services.AddScoped<IMyOperationScoped, GuidService>();
            builder.Services.AddSingleton<IMyOperationSingleton, GuidService>();
            builder.Services.AddSingleton<IBookSet, BookSet>();
            builder.Services.AddTransient<IBookWrapper, BookWrapper>();
            builder.Services.AddTransient<IBookManager, BookManager>();

            builder.Services.AddDbContext<BookDataContext>();
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
           /* builder.Services.AddSwaggerGen(option =>
            {
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                option.IncludeXmlComments(xmlPath);
            });
           */

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}