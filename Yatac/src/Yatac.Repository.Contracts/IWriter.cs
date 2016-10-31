using Yatac.Models;

namespace Yatac.Repository.Contracts
{
    public interface IWriter<in T> where T : IBaseModel
    {
        bool Save(T dataModel);
    }
}