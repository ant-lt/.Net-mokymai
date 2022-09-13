namespace P46_OOP_Baigiamasis.Models
{
    public abstract class GameUi
    {
        public string Title { get; protected set; } = "Tower of Hanoi";
        public Disk? DiskInHand { get; protected set; } = null;
        public string[,] Piles { get; protected set; }

        public abstract void Display();


    }
}