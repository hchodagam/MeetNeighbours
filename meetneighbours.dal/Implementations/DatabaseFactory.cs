using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using meetneighbours.model;
using meetneighbours.dal.Contracts;

namespace meetneighbours.dal.Implementations
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private MeetNeighboursContext dataContext;
        public MeetNeighboursContext Get()
        {
            return dataContext ?? (dataContext = new MeetNeighboursContext());
        }
        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
}
