using System.Linq.Expressions;

namespace Gerenciamento.Funcionarios.Domain.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<TEntity> FindOneAsync(Guid id);
        Task AddOneAsync(TEntity entity);
        Task ReplaceOneAsync(Expression<Func<TEntity, bool>> filter, TEntity entity);
        Task DeleteAsync(Expression<Func<TEntity, bool>> filter);
    }
}
