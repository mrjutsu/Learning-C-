using System;
namespace Game
{
    public class SniperTower : Tower
    {
        protected override int Range { get; } = 3;

        public SniperTower(MapLocation location) : base(location)
        {
        }
    }
}
