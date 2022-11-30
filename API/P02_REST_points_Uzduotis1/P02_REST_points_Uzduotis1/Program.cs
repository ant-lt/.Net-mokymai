/*
 * Uzduotis 1: Sukurkite REST endpointus jusu megstamiausiai sporto sakai (Kiekvienas model turi tureti savo REST endpointus).
            Jusu programos struktura turetu tureti maziausiai 3 modelius pvz: Sport, Athlete, Fan ir pns.
            Bent vienas is jusu modeliu turetu grazinti kompozicine struktura (Klase, kuri referuoja i kita klase).
            Bent vienas is judu modeliu privalo naudoti kolekcija.
            Visi endpointai privalo tureti sukurtus savo requestus Postman'e.
 * 
 */

namespace P02_REST_points_Uzduotis1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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