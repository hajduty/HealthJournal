namespace HealthJournal.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T Create(T entity);
        T? Get(int id);
        T Update(int id, T entity);
        bool Delete(int id);
    }
}
