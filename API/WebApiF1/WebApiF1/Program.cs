using System.Reflection;
using System.Text.Json.Serialization;
using WebApiF1.Database;
using WebApiF1.Services;

namespace WebApiF1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                               .AllowAnyMethod()
                               .AllowAnyHeader();
                    });
            });

            // Add services to the container.
            builder.Services.AddTransient<IMyOperationTransient, GuidService>();
            builder.Services.AddScoped<IMyOperationScoped, GuidService>();
            builder.Services.AddSingleton<IMyOperationSingleton, GuidService>();
            builder.Services.AddSingleton<IBookSet, BookSet>();
            builder.Services.AddTransient<IBookWrapper, BookWrapper>();
            builder.Services.AddTransient<IBookManager, BookManager>();
            builder.Services.AddTransient<IBadService, BadService>();

            builder.Services.AddHttpClient("FakeApi", client => {
                client.BaseAddress = new Uri(builder.Configuration["ExternalServices:FakeApiUri"]);
                client.Timeout = TimeSpan.FromSeconds(10);
                client.DefaultRequestHeaders.Clear();
            });
            builder.Services.AddTransient<IFakeApiProxyService, FakeApiProxyService>();

            builder.Services.AddTransient<IDivide, DivideService>();

            builder.Services.AddDbContext<BookDataContext>(option =>
            {
                option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultSQLConnection"));                
            });


            builder.Services.AddControllers()
                // reikalingas swagerio dokumentacijoje
                 .AddJsonOptions(option => option.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddSwaggerGen(option =>
            {
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                option.IncludeXmlComments(xmlPath);
            });
           

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