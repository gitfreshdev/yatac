using System;
using Yatac.Models;

namespace Yatac.Repository.Contracts
{
    public interface IReader<out T> where T : IBaseModel
    {
        T GetById(Guid id);
    }
}
