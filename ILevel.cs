using System.Collections.Generic;
namespace JumpGame
{
    public interface ILevel
    {
        void Init();
        void Tick();
        void AddPoints(int points);
        List<Block> GetBlocks();
    }
}