using System;
namespace Game
{
    public class Invader
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

        public MapLocation Location => _path.GetLocationAt(_pathStep);
        public int Health { get; private set; } = 2;
        public bool HasScored { get { return _pathStep >= _path.Length; } }
        public bool IsNeutralized => Health <= 0;
        public bool IsActive => !(IsNeutralized || HasScored);

        public Invader(Path path)
        {
            _path = path;
            // Location = _path.GetLocationAt(_pathStep);
        }

        public void Move() => _pathStep += 1;

        public void DecreaseHealth(int factor)
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
