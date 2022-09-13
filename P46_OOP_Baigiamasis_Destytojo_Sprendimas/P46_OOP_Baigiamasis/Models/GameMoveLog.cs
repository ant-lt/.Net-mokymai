namespace P46_OOP_Baigiamasis.Models
{
    public class GameMoveLog
    {
        public GameMoveLog(int moveNo)
        {
            MoveNo = moveNo;
        }

        public int MoveNo { get; set; }
        public List<int> Positions { get; set; } = new List<int>();
    }
}