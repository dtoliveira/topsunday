namespace TopSunday.Controllers
{
    public class PlayersToGame
    {
        public int PlayerID { get; set; }
        public string PlayerName { get; set; }
        public int Points { get; set; }
        public int Goals { get; set; }
        public int OwnGoals { get; set; }
        public int NumGames { get; set; }
        public bool IsSubstitute { get; set; }
        public bool Win { get; set; }
        public bool Lose { get; set; }
        public bool Draw { get; set; }
    }
}