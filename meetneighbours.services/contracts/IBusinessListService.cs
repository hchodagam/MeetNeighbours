using meetneighbours.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meetneighbours.services.contracts
{
    public interface IBusinessListService
    {
        List<BusinessLists> GetAllBusinessLists();
    }
}
