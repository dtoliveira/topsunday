using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TopSunday.Models;

namespace TopSunday.Controllers
{
    public class GameController : Controller
    {
        List<Player> matchTeamToday = new List<Player>();

        // GET: Game
        public ActionResult Match()
        {
            ListPlayers();
            ViewBag.Team = matchTeamToday;
            return View();
        }

        public void ListPlayers()
        {
            Player david = new Player();
            Player tiago = new Player();
            Player ricardo = new Player();
            Player angelo = new Player();
            Player carlos = new Player();
            Player hugo = new Player();
            Player tony = new Player();
            Player pitt = new Player();
            Player pedro = new Player();
            Player henrique = new Player();

            david.PlayedGames = 1;
            david.Name = "David";
            matchTeamToday.Add(david);

            tiago.PlayedGames = 1;
            tiago.Name = "Tiago";
            matchTeamToday.Add(tiago);

            ricardo.PlayedGames = 1;
            ricardo.Name = "Ricardo";
            matchTeamToday.Add(ricardo);

            angelo.PlayedGames = 1;
            angelo.Name = "Ângelo";
            matchTeamToday.Add(angelo);

            hugo.PlayedGames = 1;
            hugo.Name = "Hugo";
            matchTeamToday.Add(hugo);

            carlos.PlayedGames = 1;
            carlos.Name = "Carlos";
            matchTeamToday.Add(carlos);

            tony.PlayedGames = 1;
            tony.Name = "António";
            matchTeamToday.Add(tony);

            pedro.PlayedGames = 1;
            pedro.Name = "Pedro";
            matchTeamToday.Add(pedro);

            henrique.PlayedGames = 1;
            henrique.Name = "Henrique";
            matchTeamToday.Add(henrique);

            pitt.PlayedGames = 1;
            pitt.Name = "Pitt";
            matchTeamToday.Add(pitt);
        }
    }
}