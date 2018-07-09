using System;
namespace Game
{
    public class Tower
    {

        private readonly MapLocation _location;

        protected virtual int Range { get; } = 1;
        protected virtual int Power { get; } = 1;
        protected virtual double Accuracy { get; } = .75;

        private static readonly Random _random = new Random();

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public bool IsSuccessfulShot()
        {
            return _random.NextDouble() < Accuracy;
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
                if (invader.IsActive && _location.InRangeOf(invader.Location, Range))
                {
                    if (IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(Power);
                        Console.WriteLine("Shot at and hit an invader!");

                        if (invader.IsNeutralized)
                        {
                            Console.WriteLine("Neutralized an invader!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Shot at and missed an invader!");
                    }
                    break;
                }
            }
        }
    }
}
