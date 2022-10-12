using FootballManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Contracts
{
    public interface IPlayerService
    {
        public IEnumerable<PlayerViewModel> GetAllPlayers();

        public bool AddPlayer(CreatePlayerViewModel model, string userId);

        public bool AddToCollection(int playerId, string userId);

        public IEnumerable<PlayerViewModel> GetUserCollection(string userId);

        public bool RemoveFromCollection(int playerId, string userId);
    }
}
