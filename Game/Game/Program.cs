using System;

namespace Game
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Map map = new Map(8, 5);

            /*
            Point x = new MapLocation(4, 2);

            map.OnMap(new MapLocation(0, 0));

            bool isOnMap = map.OnMap(x);

            // Type checking
            Console.WriteLine(x is MapLocation); // true
            Console.WriteLine(x is Point); // true

            Point point = new Point(0, 0);
            // point is not a MapLocation
            Console.WriteLine(point is MapLocation); // false
            */

            try
            {
                MapLocation mapLocation = new MapLocation(20, 20, map);
            }
            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (GameException)
            {
                Console.WriteLine("Unhandled GameException");
            }
            // Catching general exceptions should only be done in the main method
            catch (Exception)
            {
                // Console.WriteLine("That map location is not on the map");
                // Console.WriteLine(ex.Message);
                Console.WriteLine("Unhandled Exception");
            }

        }
    }
}
