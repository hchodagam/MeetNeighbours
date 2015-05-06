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
    public class BusinesslistService : IBusinessListService
    {
        #region Constructor
        IUnitOfWork _unitOfWork;
        IBusinessListsRepository _BusinessListsRepository;

        public BusinesslistService(
            IUnitOfWork unitOfWork,
            IBusinessListsRepository BusinessListsRepository)
        {
            this._unitOfWork = unitOfWork;
            this._BusinessListsRepository = BusinessListsRepository;

        }
        #endregion

        public List<DTO.BusinessLists> GetAllBusinessLists()
        {
            throw new NotImplementedException();
        }
    }
}
