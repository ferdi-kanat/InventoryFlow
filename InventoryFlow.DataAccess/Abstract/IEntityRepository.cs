using System.Diagnostics.CodeAnalysis;
using InventoryFlow.Entities.Abstract;
using System.Linq.Expressions;

namespace InventoryFlow.DataAccess.Abstract
{
    // T = The Entity (e.g. , Product, Category)
    // where T : class, IEntity, new() => ensures we only use this for our database tables
    [SuppressMessage("Design", "CA1716:IdentifiersShouldNotMatchKeywords", Justification = "Interface name is shared across solution and not ambiguous in consuming languages.")]
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        // Get a list. "filter = null" means return all if no filter is provided.
        // Expression<Func...> allows us to write lambda queries like p => p.Id == 1
        List<T> GetAll(Expression<Func<T, bool>>? filter = null);

        // Get a single item
        T? Get(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}