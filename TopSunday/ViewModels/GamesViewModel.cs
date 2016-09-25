using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TopSunday.Controllers;
using TopSunday.Models;
using TopSunday.SpecificObjects;

namespace TopSunday.ViewModels
{
    public class GamesViewModel
    {
        public GamesViewModel()
        {
            PlayerConfirmations = new List<PlayerConfirmation>();
            GoalsTeamA = new List<PlayersToGame>();
            GoalsTeamB = new List<PlayersToGame>();
        }

        public List<ClassificationList> Classification { get; set; }
        public List<PlayerConfirmation> PlayerConfirmations { get; set; }
        public string LinkTeamA { get; internal set; }
        public string LinkTeamB { get; internal set; }
        public List<Player> Players { get; set; }
        public bool IsSubstitute { get; set; }
        public string Season { get; set; }
        public string GameType { get; set; }
        public PlayerViewModel NewPlayer { get; set; }
        public bool hasOpengames { get; set; }
        public bool HasTeams { get; internal set; }
        public List<PlayersToGame> GoalsTeamA { get; internal set; }
        public List<PlayersToGame> GoalsTeamB { get; internal set; }
    }
}
