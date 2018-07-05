using System;

namespace Game
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Tower tower = new Tower();
            Map map = new Map(8, 5);

            Point point = new Point(4, 2);
            bool isOnMap = map.OnMap(point);
        }
    }
}
