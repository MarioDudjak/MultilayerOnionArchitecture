using System.Threading.Tasks;

namespace Project.Repository.Common
{
    public interface IGenericRepository
    {
        #region Methods

        IUnitOfWork CreateUnitOfWork();
        /// <summary>
        /// Adds the entity of the type T asynchronously.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity">The entity to be added.</param>
        /// <returns></returns>
        Task<int> AddAsync<T>(T entity) where T : class;

        #endregion Methods
    }
}
