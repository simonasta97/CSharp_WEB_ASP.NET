using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Contracts
{
    public interface IValidationService
    {
        public bool ValidateModel(object model);
    }
}
