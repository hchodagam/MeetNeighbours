using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using meetneighbours.model;
using meetneighbours.dal.Contracts;

namespace meetneighbours.dal.Implementations
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private MeetNeighboursContext dataContext;
        private readonly IDbSet<T> dbset;
        protected Repository(IDatabaseFactory databaseFactory)
        {
            DatabaseFactory = databaseFactory;
            dbset = DataContext.Set<T>();
        }

        protected IDatabaseFactory DatabaseFactory
        {
            get;
            private set;
        }

        protected MeetNeighboursContext DataContext
        {
            get { return dataContext ?? (dataContext = DatabaseFactory.Get()); }
        }
        public virtual void Add(T entity)
        {
            dbset.Add(entity);
        }
        public virtual void Update(T entity)
        {
            dbset.Attach(entity);
            dataContext.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Delete(T entity)
        {
            dbset.Remove(entity);
        }
        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IQueryable<T> objects = dbset.Where<T>(where).AsQueryable();
            foreach (T obj in objects)
                dbset.Remove(obj);
        }
        public virtual T GetById(int id)
        {
            return dbset.Find(id);
        }
        public virtual T GetById(string id)
        {
            return dbset.Find(id);
        }
        public virtual IQueryable<T> GetAll()
        {
            return dbset.AsQueryable();
        }
        public virtual IQueryable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return dbset.Where(where).AsQueryable();
        }
        public T Get(Expression<Func<T, bool>> where)
        {
            return dbset.Where(where).FirstOrDefault<T>();
        }
       
    }
}
