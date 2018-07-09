using System;
namespace Game
{
    public class LaserTower : Tower
    {
        protected override double Accuracy { get; } = .95;

        public LaserTower(MapLocation location) : base(location)
        {
        }
    }
}
