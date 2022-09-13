namespace P46_OOP_Baigiamasis.Extensions
{
    public static class PileExtension
    {
        public static string FromToText(int col)
        {
            return col switch
            {
                1 => "pirmo",
                2 => "antro",
                3 => "trečio",
                _ => ""
            };
        }

        public static string ToToText(int col)
        {
            return col switch
            {
                1 => "pirmą",
                2 => "antrą",
                3 => "trečią",
                _ => ""
            };
        }
        public static int ToToNumber(string col)
        {
            return col switch
            {
                "pirmą" => 1,
                "antrą" => 2,
                "trečią" => 3,
                _ => -1
            };
        }
    }
}
