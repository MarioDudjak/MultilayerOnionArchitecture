using System.Threading.Tasks;

namespace Project.Repository.Common
{
    public interface IGenericRepository
    {
        IUnitOfWork CreateUnitOfWork();
        /// <summary>
        /// Adds the entity of the type T asynchronously.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity">The entity to be added.</param>
        /// <returns></returns>
        Task<T> CreateAsync<T>(T entity) where T : class;
    }
}
