using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using meetneighbours.model;


namespace meetneighbours.dal.Contracts
{
    public interface IDatabaseFactory : IDisposable
    {
        MeetNeighboursContext Get();
    }
}
