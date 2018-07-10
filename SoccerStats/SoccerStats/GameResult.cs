using System;
namespace SoccerStats
{
    public class GameResult
    {
        public DateTime GameDate { get; set; }
        public string TeamName { get; set; }
        public HomeOrAway HomeOrAway { get; set; }

        public GameResult()
        {
        }
    }

    public enum HomeOrAway // : byte (type)
    {
        Home,
        Away
    }
}
