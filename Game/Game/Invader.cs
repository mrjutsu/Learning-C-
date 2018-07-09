using System;
namespace Game
{
    public abstract class Invader : IInvader
    {

        /*
        // Field
        private MapLocation _location;

        // Property
        public MapLocation Location
        {
            get
            {
                return _location;
            }
            private set
            {
                _location = value;
            }
            // set => _location = value;
        }
        */

        // Auto-property
        // public MapLocation Location { get; private set; }

        // Computed property
        /*
        public MapLocation Location
        {
            get
            {
                return _path.GetLocationAt(_pathStep);
            }
        }
        */


        private int _pathStep = 0;
        private readonly Path _path;

        protected virtual int StepSize { get; } = 1;

        public MapLocation Location => _path.GetLocationAt(_pathStep);
        public abstract int Health { get; protected set; }
        public bool HasScored { get { return _pathStep >= _path.Length; } }
        public bool IsNeutralized => Health <= 0;
        public bool IsActive => !(IsNeutralized || HasScored);

        public Invader(Path path)
        {
            _path = path;
            // Location = _path.GetLocationAt(_pathStep);
        }

        public virtual void Move() => _pathStep += StepSize;

        public virtual void DecreaseHealth(int factor)
        {
            Health -= factor;
        }
        /*
        public void Move()
        {
            _pathStep += 1;
            // Location = _path.GetLocationAt(_pathStep);
        }
        */

        // Getter and setter methods
        /*
        public MapLocation GetLocation()
        {
            return _location;
        }

        public void SetLocation(MapLocation value)
        {
            _location = value;
        }
        */
    }
}
