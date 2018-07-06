using System;
namespace Game
{
    public class Tower
    {

        private readonly MapLocation _location;

        private const int _range = 1;
        private const int _power = 1;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            // int index = 0;
            /*
            while (index < invaders.Length){
                Invader invader = invaders[index];

                index++;
            }
            */

            /*
            for (index = 0; index < invaders.Length; index++)
            {
                Invader invader = invaders[index];
            }
            */

            foreach (Invader invader in invaders)
            {
                if (invader.IsActive && _location.InRangeOf(invader.Location, _range))
                {
                    invader.DecreaseHealth(_power);
                    break;
                }
            }
        }
    }
}
