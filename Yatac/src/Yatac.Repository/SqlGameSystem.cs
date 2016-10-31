using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yatac.Models;
using Yatac.Repository.Contracts;

namespace Yatac.Repository
{
    public class SqlGameSystem : IGameSystem
    {
        public GameSystem GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Save(GameSystem dataModel)
        {
            throw new NotImplementedException();
        }

        public GameSystem GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
