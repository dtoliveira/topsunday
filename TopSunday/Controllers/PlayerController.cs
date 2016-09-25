using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TopSunday.Models;
using TopSunday.ViewModels;

namespace TopSunday.Controllers
{
    public class PlayerController : Controller
    {
        // GET: Player
        public ActionResult AddPlayer(PlayerViewModel player)
        {
            if (player != null)
            {


                using (ApplicationDbContext ctx = new ApplicationDbContext())
                {
                    Player addPlayer = new Player
                    {
                        Name = player.Name,
                        PhoneNumber = player.PhoneNumber,
                        Email = player.Email

                    };

                    ctx.Player.Add(addPlayer);
                    ctx.SaveChanges();


                    if (player.Wednesday.Equals(true))
                    {
                        ctx.Players_GameType.Add(new Players_GameType
                        {
                            PlayerID = addPlayer.ID,
                            GameTypeID = 2,
                            IsSubstitute = true
                        });

                        ctx.SaveChanges();

                        if (player.Sunday.Equals(true))
                        {
                            ctx.Players_GameType.Add(new Players_GameType
                            {
                                PlayerID = addPlayer.ID,
                                GameTypeID = 1,
                                IsSubstitute = true
                            });

                            ctx.SaveChanges();
                        }

                        ctx.Dispose();
                    }
                }

            }
            return View();
        }
    }
}