using meetneighbours.dal.Contracts;
using meetneighbours.repository;
using meetneighbours.services.contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meetneighbours.services.Implementations
{
   public class CityService : ICityService
    {
         #region Constructor
        IUnitOfWork _unitOfWork;
        ICityRepository _CityRepository;

        public CityService(
            IUnitOfWork unitOfWork,
            ICityRepository CityRepository)
        {
            this._unitOfWork = unitOfWork;
            this._CityRepository = CityRepository;

        }
        #endregion

        public List<DTO.City> getAllCities()
        {
            return _CityRepository.GetAll().ToList();
        }
    }
}
