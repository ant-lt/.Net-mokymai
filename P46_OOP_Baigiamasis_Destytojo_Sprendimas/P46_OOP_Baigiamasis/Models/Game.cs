namespace P46_OOP_Baigiamasis.Models
{
    public class Game
    {
        public int PilesCount { get; init; }
        public int DiskCount { get; init; }
        public List<Disk> Disks { get; private set; }
        public bool HasDiskInHand => Disks.Last().Y == null;
        public bool IsEndState => Disks.Count(d => d.X == PilesCount - 1) == DiskCount;
        public int MoveNo { get; set; } = 0;
        public string HelpText { get; set; } = "";
        public string ErrText { get; set; } = "";

        public Game(int pilesCount, int discCount)
        {
            PilesCount = pilesCount;
            DiskCount = discCount;
        }

        public void Build(List<Disk> disks)
        {
            Disks = disks;
        }



    }
}