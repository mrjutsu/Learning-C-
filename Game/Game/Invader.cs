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
        public MapLocation Location { get; private set; }

        private int _pathStep = 0;

        private readonly Path _path;

        public Invader(Path path)
        {
            _path = path;
            Location = _path.GetLocationAt(_pathStep);
        }

        public void Move()
        {
            _pathStep += 1;
            Location = _path.GetLocationAt(_pathStep);
        }

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
