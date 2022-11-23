namespace P04_EF_Applying_To_API.Models.Dto
{
    public class GetDishDTO
    {
        public GetDishDTO(Disch disch)
        {
            Name= disch.Name;

            Type= disch.Type;

            SpiceLevel= disch.SpiceLevel;

            Country= disch.Country;

        }

        public string Name { get; set; }

        public string Type { get; set; }

        public string SpiceLevel { get; set; }

        public string Country { get; set; }

    }
}
