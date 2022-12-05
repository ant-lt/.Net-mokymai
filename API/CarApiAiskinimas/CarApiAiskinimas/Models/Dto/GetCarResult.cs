namespace CarApiAiskinimas.Models.Dto
{
    public class GetCarResult
    {
        /// <summary>
        /// Autogeneracija id is duomenu bazes
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Automobilio gamintojo pavadinimas
        /// </summary>
        public string Mark { get; set; }
        public string Model { get; set; }
        /// <summary>
        /// Automobilio pagaminimo metai formatu yyyy-MM-dd
        /// </summary>
        public string Year { get; internal set; }
        /// <summary>
        /// Automobilio valstybinis numeris. Jei Automobilis neregistruotas - grazina 'neregistruota'
        /// </summary>
        public string PlateNumber { get; set; }
        /// <summary>
        /// Automobilio pavaru dezes tipas. Galimos reiksmes Manual ir Automatic
        /// </summary>
        public string GearBox { get; internal set; }

        /// <summary>
        /// Automobilio kuro tipas. Galimos reiksmes: Petrol ir Electric
        /// </summary>
        public string Fuel { get; set; }
       
    }
}
