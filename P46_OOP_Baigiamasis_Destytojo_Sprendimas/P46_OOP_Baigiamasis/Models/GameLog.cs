namespace P46_OOP_Baigiamasis.Models
{
    public class GameLog
    {
        public DateTime StartTime { get; set; }
        public List<GameMoveLog> Moves { get; set; }
        public bool IsCompleted
        {
            get
            {
                var lastmove = Moves[Moves.Count - 1];
                for (int i = 0; i < lastmove.Positions.Count; i++)
                {
                    if (lastmove.Positions[i] != 3)
                        return false;
                }
                return true;
            }
        }



    }
}