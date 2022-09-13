using P46_OOP_Baigiamasis.Models;

namespace P46_OOP_Baigiamasis.Services
{
    public interface IGameLogManager
    {
        void Write(Game game, string input);
        List<GameLog> Read();
    }
}