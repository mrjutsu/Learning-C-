using System;
namespace SoccerStats
{
    //public class Player
    //{
    //    public Player()
    //    {
    //    }
    //}
    public class RootObject
    {
        public Player[] Player { get; set; }
    }

    public class Player
    {
        public int Assists { get; set; }
        public int BigChancesCreated { get; set; }
        public int Blocks { get; set; }
        public int? ChanceOfPlayingNextRound { get; set; }
        public int? ChanceOfPlayingThisRound { get; set; }
        public int CleanSheets { get; set; }
        public int Clearances { get; set; }
        public int Code { get; set; }
        public int CostChangeEvent { get; set; }
        public int CostChangeEventFall { get; set; }
        public int CostChangeStart { get; set; }
        public int CostChangeStartFall { get; set; }

        public string second_name { get; set; }
    }
}
