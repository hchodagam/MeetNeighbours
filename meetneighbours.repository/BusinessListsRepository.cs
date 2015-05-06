using meetneighbours.dal.Contracts;
using meetneighbours.dal.Implementations;
using meetneighbours.DTO;
using meetneighbours.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meetneighbours.repository
{
    public class BusinessListsRepository : Repository<BusinessLists>, IBusinessListsRepository
    {
        private MeetNeighboursContext dataContext;

        protected IDatabaseFactory DatabaseFactory
        {
            get;
            private set;
        }

        public BusinessListsRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
            DatabaseFactory = databaseFactory;
        }

        protected MeetNeighboursContext DataContext
        {
            get { return dataContext ?? (dataContext = DatabaseFactory.Get()); }
        }

    }
    public interface IBusinessListsRepository : IRepository<BusinessLists> { }
}
