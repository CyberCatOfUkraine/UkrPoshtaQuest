using System.Collections.Generic;

namespace UkrPoshtaQuest.DbMagick
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        void Clear();
    }
}
