using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yatac.Models;

namespace Yatac.Repository.Contracts
{
    public interface IGameSystem : IReader<GameSystem>, IWriter<GameSystem>
    {
        GameSystem GetByName(string name);
    }
}
