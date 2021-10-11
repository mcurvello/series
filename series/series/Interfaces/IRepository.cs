using System.Collections.Generic;

namespace series.Interfaces
{
    public interface IRepository<T>
    {
        List<T> List();
        T ReturnFromId(int id);
        void Insert(T  entity);
        void Exclude(int id);
        void Update(int id, T entity);
        int NextId();
    }
}
