namespace P46_OOP_Baigiamasis.Models
{
    public class Disk
    {
        public Disk(int size, int? x, int? y)
        {
            Size = size;
            X = x;
            Y = y;
        }

        public int Size { get; set; }
        public int? X { get; set; }
        public int? Y { get; set; }
    }
}