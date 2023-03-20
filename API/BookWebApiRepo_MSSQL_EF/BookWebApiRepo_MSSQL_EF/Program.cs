using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using BookWebApiRepo_MSSQL_EF.Data;
using BookWebApiRepo_MSSQL_EF.Repositories;
using BookWebApiRepo_MSSQL_EF.Repositories.IRepository;
using BookWebApiRepo_MSSQL_EF.Services;
using BookWebApiRepo_MSSQL_EF.Services.IServices;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;

namespace BookWebApiRepo_MSSQL_EF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddDbContext<BookContext>(option =>
            {
                option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultSQLConnection"));
               // option.UseLazyLoadingProxies();
            });

            builder.Services.AddTransient<IBookWrapper, BookWrapper>();
            builder.Services.AddTransient<IReservationWrapper, ReservationWrapper>();

            builder.Services.AddScoped<IBookRepository, BookRepository>();

            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<IPasswordService, PasswordService>();
            builder.Services.AddScoped<IJwtService, JwtService>();

            builder.Services.AddScoped<IReservationRepository, ReservationRepository>();

            //to do prideti IFineService ir uzregistruoti DI , nereikes new daryti.

            //////////////////
            builder.Services.AddHttpClient("ShippingApiUri", client => {
                client.BaseAddress = new Uri(builder.Configuration["ExternalServices:ShippingApiUri"]);
                client.Timeout = TimeSpan.FromSeconds(10);
                client.DefaultRequestHeaders.Clear();
            });

            builder.Services.AddTransient<IShippingApiProxyService, ShippingApiProxyService>();

            ///////////////////

            //           builder.Services.AddScoped<IBookReservationManager, BookReservationManager>();



            var key = builder.Configuration.GetValue<string>("ApiSettings:Secret");

            builder.Services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(x =>
                {
                    x.RequireHttpsMetadata = false;
                    x.SaveToken = true;
                    x.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key)),
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                });

            builder.Services.AddControllers()
                  .AddJsonOptions(option => option.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSwaggerGen();

            // papildomai swager dokumentacijai. Reikia projekte uzdeti varnele prie Output Generate a file containing API documentation.
            builder.Services.AddSwaggerGen(option =>
            {
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                option.IncludeXmlComments(xmlPath);

                // This is added to show JWT UI part in Swagger
                option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Description =
                        "JWT Authorization header is using Bearer scheme. \r\n\r\n" +
                        "Enter 'Bearer' and token separated by a space. \r\n\r\n" +
                        "Example: \"Bearer d5f41g85d1f52a\"",
                    Name = "Authorization", // Header key name
                    In = ParameterLocation.Header,
                    Scheme = "Bearer",
                    BearerFormat = "JWT"
                });

                option.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme()
                        {
                            Reference = new OpenApiReference()
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                            Scheme = "oauth2",
                            Name = "Bearer",
                            In = ParameterLocation.Header
                        },
                        new List<string>()
                    }
                });
            });



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            //------------------
            app.UseAuthentication(); // Order matters
            app.UseAuthorization();
            //--------------------

            app.MapControllers();

            app.Run();
        }
    }
}