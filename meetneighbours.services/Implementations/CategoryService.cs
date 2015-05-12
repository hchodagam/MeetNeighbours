using meetneighbours.dal.Contracts;
using meetneighbours.DTO;
using meetneighbours.repository;
using meetneighbours.services.contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meetneighbours.services.Implementations
{
    public class CategoryService : ICategoryService
    {
        #region Constructor
        IUnitOfWork _unitOfWork;
        ICategoryRepository _CategoryRepository;

        public CategoryService(
            IUnitOfWork unitOfWork,
            ICategoryRepository CategoryRepository)
        {
            this._unitOfWork = unitOfWork;
            this._CategoryRepository = CategoryRepository;

        }
        #endregion
        public List<Category> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public void AddCategory(Category Category)
        {
            _CategoryRepository.Add(Category);
            _unitOfWork.Commit();
        }
    }
}
