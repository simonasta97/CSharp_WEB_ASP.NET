using BasicWebServer.Server.Attributes;
using BasicWebServer.Server.Controllers;
using BasicWebServer.Server.HTTP;
using FootballManager.Contracts;
using FootballManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Controllers
{
    public class PlayersController : Controller
    {
        private readonly IPlayerService playerService;

        public PlayersController(Request request, IPlayerService _playerService) 
            : base(request)
        {
            playerService = _playerService;
        }

        [Authorize]
        public Response All()
        {
            var players = playerService.GetAllPlayers();

            return View(new { players = players, IsAuthenticated = true });
        }

        [Authorize]
        public Response Add()
        {
            return View(new { IsAuthenticated = true });
        }

        [Authorize]
        [HttpPost]
        public Response Add(CreatePlayerViewModel model)
        {
            var isSuccessfullyAdded = playerService.AddPlayer(model, User.Id);

            if (!isSuccessfullyAdded)
            {
                return View(new { IsAuthenticated = true });
            }

            return Redirect("/Players/All");
        }

        [Authorize]
        public Response Collection()
        {
            var players = playerService.GetUserCollection(User.Id);

            return View(new { players = players, IsAuthenticated = true });
        }

        [Authorize]
        public Response AddToCollection(int playerId)
        {
            var isSuccessfullyAdded = playerService.AddToCollection(playerId, User.Id);

            return Redirect("/Players/All");
        }

        [Authorize]
        public Response RemoveFromCollection(int playerId)
        {
            var isSuccessfullyRemoved = playerService.RemoveFromCollection(playerId, User.Id);

            return Redirect("/Players/Collection");
        }
    }
}
