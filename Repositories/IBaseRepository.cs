namespace Repositories;
public interface IBaseRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllData();
    Task<T> GetDataById(int Id);
    Task<T> Create(T model);
    Task<T> Update(T model, int Id);
    Task DeleteById(int Id);
}
