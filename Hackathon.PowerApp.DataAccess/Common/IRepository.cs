
namespace Hackathon.PowerApp.DataAccess.Common
{
    public interface IRepository<T>
           where T : IEntity
    {
        T GetById(Guid id);
        IList<T> FindAll();
        T Add(T entity);
        T Update(Guid id, T entity);
        void Remove(Guid id);
        void Save();
    }
}
