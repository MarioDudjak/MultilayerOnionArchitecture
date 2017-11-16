using Project.DAL;
using Project.Repository.Common;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Project.Repository
{
    public class GenericRepository : IGenericRepository
    {
        protected IDbContext DbContext { get; private set; }
        protected IUnitOfWorkFactory UnitOfWorkFactory { get; private set; }

        public GenericRepository(IDbContext dbContext, IUnitOfWorkFactory unitOfWorkFactory)
        {
            DbContext = dbContext;
            UnitOfWorkFactory = unitOfWorkFactory;
        }

        public IUnitOfWork CreateUnitOfWork()
        {
            return UnitOfWorkFactory.CreateUnitOfWork();
        }

        public async Task<int> AddAsync<T>(T entity) where T : class
        {
            DbEntityEntry dbEntityEntry = DbContext.Entry(entity);
            if (dbEntityEntry.State != EntityState.Detached)
            {
                dbEntityEntry.State = EntityState.Added;
            }
            else
            {
                DbContext.Set<T>().Add(entity);
            }
            try
            {
                return await DbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
                throw;
            }

        }
    }
    }
