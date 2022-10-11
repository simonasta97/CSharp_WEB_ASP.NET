using FootballManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Contracts
{
    public interface IUserService
    {
        public bool Register(RegisterViewModel model);

        public string Login(LoginViewModel model);
    }
}
