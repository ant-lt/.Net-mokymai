namespace P034_Enum
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Enums!");

            int sunday = 1;
            int monday = 2;
            int tuesday = 3;
            int wednesday = 4;
            int thursday = 5;
            int friday = 6;
            int saturday = 7;

            int dayOfWeek = friday;
            //------------------------------------------

            EDaysOfWeek today = EDaysOfWeek.Tuesday;
            Console.WriteLine($"today - {today}");
            int todayInt = (int)EDaysOfWeek.Tuesday;
            Console.WriteLine($"todayInt - {todayInt}");

            int todayNumber = 2;
            EDaysOfWeek today1 = (EDaysOfWeek)todayNumber;
            Console.WriteLine($"today1 - {today1}");

            EDaysOfWeek today2 = (EDaysOfWeek)2;
            Console.WriteLine($"today2 - {today2}");
            //------------------------------------------
            //statinės klasės enumeracijos

            int today3 = DayOfWeekEnum.Tuesday;


            CustomEnum today4 = DaysOfWeekCustomEnum.Tuesday;

        }
    }

    public enum EDaysOfWeek {Sunday, Monday,Tuesday, Wednesday, Friday, Saturday}
    public enum EDaysOfWeek1 { Sunday = 5, Monday=6 , Tuesday= 7, Wednesday=8, Friday=9, Saturday =11 }

    public class CustomEnum
    {
        public CustomEnum(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString() => Name;

    }

}