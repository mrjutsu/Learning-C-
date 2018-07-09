using System;
namespace Game
{
    public interface IInvader
    {

        MapLocation Location { get; }
        int Health { get; }
        bool HasScored { get; }
        bool IsNeutralized { get; }
        bool IsActive { get; }

        void Move();

        void DecreaseHealth(int factor);

    }
}
