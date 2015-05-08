using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using meetneighbours.DTO;

namespace meetneighbours.services.contracts
{
   public interface ICityService
    {
       List<City> getAllCities();
    }
}
