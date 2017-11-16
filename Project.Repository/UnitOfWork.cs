using System;
using System.Threading.Tasks;
using Project.Repository.Common;
using Project.DAL;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Transactions;

namespace Project.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        protected IDbContext DbContext { get; private set; }

        public UnitOfWork(IDbContext dbContext)
        {
            if (dbContext == null)
            {
                throw new ArgumentNullException("DbContext");
            }
            DbContext = dbContext;
        }

        

        public async Task<int> CommitAsync()
        {
            int result = 0;
            using (TransactionScope scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                result = await DbContext.SaveChangesAsync();
                scope.Complete();
            }
            return result;
        }

        public void Dispose()
        {
            DbContext.Dispose();
        }
    }
}
