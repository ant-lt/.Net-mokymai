using P46_OOP_Baigiamasis.Models;

namespace P46_OOP_Baigiamasis.Interfaces
{
    public interface IGameLogHandler
    {
        DateTime StartTime { get; }
        void Write(Game game, string input);
        List<GameLog> Read();
    }
}
