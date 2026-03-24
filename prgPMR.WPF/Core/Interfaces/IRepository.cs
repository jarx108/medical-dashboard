namespace prgPMR.WPF.Core.Interfaces;

/// <summary>
/// Generic async repository contract.
/// All module-specific repositories extend this.
/// </summary>
public interface IRepository<T> where T : class
{
    Task<IReadOnlyList<T>> GetAllAsync(int userId);
    Task<T?>               GetByIdAsync(int id);
    Task<int>              AddAsync(T entity);
    Task                   UpdateAsync(T entity);
    Task                   DeleteAsync(int id);
}
