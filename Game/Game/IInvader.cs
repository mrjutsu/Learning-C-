using System;
namespace Game
{
    public interface IMappable
    {
        MapLocation Location { get; }
    }

    public interface IMovable
    {
        void Move();
    }

    public interface IInvader : IMappable, IMovable
    {
        int Health { get; }
        bool HasScored { get; }
        bool IsNeutralized { get; }
        bool IsActive { get; }

        void DecreaseHealth(int factor);

    }
}
